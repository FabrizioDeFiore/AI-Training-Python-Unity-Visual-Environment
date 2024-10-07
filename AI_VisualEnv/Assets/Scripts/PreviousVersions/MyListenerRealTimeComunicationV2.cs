using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Collections.Generic;
public class MyListenerRealTimeComunicationsV2 : MonoBehaviour
{ 
    public int port = 25002;

    // Public references to the three objects to update
    public Transform objectToUpdate1;
    public Transform objectToUpdate2;
    public Transform objectToUpdate3;

    private Thread receiveThread;
    private TcpListener server;
    private TcpClient client;
    private bool isRunning = true;

    // Queues for each data stream
    private Queue<float> chpTemp1Queue = new Queue<float>();
    private Queue<float> loopTemp1Queue = new Queue<float>();
    private Queue<float> stoomQueue = new Queue<float>();

    void Start(){
        if (objectToUpdate1 == null || objectToUpdate2 == null || objectToUpdate3 == null){
            Debug.LogError("Assign all three objects in the Inspector!");
            return;
        }

        receiveThread = new Thread(ReceiveData);
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData(){
        server = new TcpListener(IPAddress.Any, port);
        server.Start();
        while (isRunning){
            try{
                client = server.AcceptTcpClient();
                using (NetworkStream stream = client.GetStream()){
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    StringBuilder dataBuilder = new StringBuilder();
                    while (isRunning){
                        int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                        if (bytesRead == 0){
                            // Client disconnected
                            Debug.Log("Breaking connection");
                            break;
                        }
                        string dataString = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        dataBuilder.Append(dataString);
                        // Process data when a newline is received
                        if (dataBuilder.ToString().EndsWith("\n")){
                            string[] dataLines = dataBuilder.ToString().Split('\n');
                            foreach (string line in dataLines){
                                if (line.Trim() != ""){ // Ignore empty lines
                                    string[] dataParts = Regex.Split(line.Trim(), @"\s+"); // Split by whitespace
                                    if (dataParts.Length >= 2){
                                        // Store the 2 part of the data sent in the corresponding var 
                                        string dataStreamName = dataParts[0];
                                        float dataPoint;
                                        // Attempt to parse data point as float
                                        if (float.TryParse(dataParts[1], out dataPoint)){
                                            // Enqueue data point based on the data stream name
                                            if (dataStreamName == "CHPTemp1"){
                                                chpTemp1Queue.Enqueue(dataPoint);
                                            }else if (dataStreamName == "LoopTemp1"){
                                                loopTemp1Queue.Enqueue(dataPoint);
                                            }else if (dataStreamName == "Stoom"){
                                                stoomQueue.Enqueue(dataPoint);
                                            }else{
                                                Debug.LogWarning("Unknown data stream name: " + dataStreamName);
                                            }
                                        }else{
                                            Debug.LogError("Failed to parse data point: " + line);
                                        }
                                    }else{
                                        Debug.LogError("Invalid data format: " + line);
                                    }
                                }
                            }
                            dataBuilder.Clear(); // Reset for the next frame
                        }
                    }
                }
            }catch (Exception e){
                Debug.LogError("Error receiving data: " + e.Message);
            }finally{
                if (client != null){
                    Debug.Log("Finally");
                    client.Close();
                }
            }
        }
        server.Stop();
    }

    void Update(){
        // Update object Y positions based on their respective queues
        if (chpTemp1Queue.Count > 0){
            float newPositionY = chpTemp1Queue.Dequeue();
            objectToUpdate1.transform.position = new Vector3(objectToUpdate1.transform.position.x, newPositionY, objectToUpdate1.transform.position.z);
        }
        if (loopTemp1Queue.Count > 0){
            float newPositionY = loopTemp1Queue.Dequeue();
            objectToUpdate2.transform.position = new Vector3(objectToUpdate2.transform.position.x, newPositionY, objectToUpdate2.transform.position.z);
        }
        if (loopTemp1Queue.Count > 0){
            float newPositionY = stoomQueue.Dequeue();
            objectToUpdate3.transform.position = new Vector3(objectToUpdate3.transform.position.x, newPositionY, objectToUpdate3.transform.position.z);
        }
    }
}
