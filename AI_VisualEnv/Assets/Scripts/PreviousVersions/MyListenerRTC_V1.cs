using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Collections.Generic;
//using System.Exception;
public class MyListenerRTC_V1: MonoBehaviour{
    public int port = 25004;  
    public Transform objectToUpdate;  
    private Thread receiveThread;
    private TcpListener server;
    private TcpClient client;
    private bool isRunning = true;
    private Queue<float> dataQueue = new Queue<float>(); 

    void Start(){
        if (objectToUpdate == null){
            Debug.LogError("No object assigned in MyListenerRealTime!");
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
                Debug.Log("Fas is in the try");
                client = server.AcceptTcpClient();
                using (NetworkStream stream = client.GetStream()){
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    StringBuilder dataBuilder = new StringBuilder();
                    List<Queue<float>> dataQueues = new List<Queue<float>>();  // List for multiple queues
                    // Initialize queues for each data stream
                    dataQueues.Add(new Queue<float>());  // CHPTemp1 queue
                    // Add more queues if needed (LoopTemp1, Stoom)
                    while (isRunning){
                        int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                        if (bytesRead == 0){
                            // Client disconnected
                            break;
                        } 
                        string dataString = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        dataBuilder.Append(dataString);
                        // Process data when a newline is received
                        if (dataBuilder.ToString().EndsWith("\n")){
                            string[] dataLines = dataBuilder.ToString().Split('\n');
                            foreach (string line in dataLines){
                                if (line.Trim() != ""){ // Ignore empty lines
                                    float dataPoint = float.Parse(line);
                                    // Enqueue data point based on the current stream
                                    dataQueues[0].Enqueue(dataPoint); // CHPTemp1 queue
                                    // Modify index for other data streams
                                }
                            }
                        }
                    }
                    dataBuilder.Clear();  // Reset for the next frame
                }
            }catch (Exception e){
                Debug.LogError("Error receiving data: "  + e.Message);
            }finally{
                if (client != null){
                    Debug.Log("Finally");
                    client.Close();
                }
            }
        }
        server.Stop();
    }
}

