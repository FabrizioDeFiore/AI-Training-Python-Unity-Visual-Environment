<a name="readme-top"></a>
<p align="center"> 
<a><img alt="Static Badge" src="https://img.shields.io/badge/1.0.2-maker?style=for-the-badge&logo=github&logoColor=white&label=version&color=lightblue"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/11%2F06%2F2024-maker?style=for-the-badge&logo=clockify&logoColor=white&label=last%20edited&color=violet"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/python-maker?style=for-the-badge&logo=python&logoColor=red&label=language&labelColor=white&color=red"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/c%23-maker?style=for-the-badge&logo=c%23&logoColor=green&label=language&labelColor=white&color=green"></a>
<a href="https://www.linkedin.com/in/fabrizio-de-fiore/"><img alt="Static Badge" src="https://img.shields.io/badge/Linkedin-maker?style=for-the-badge&logo=linkedin&color=blue"></a>
</p>


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/27a4a64f-8557-4344-9081-355fd9a9f756" alt="Logo" ">
  </a>
  <h1 align="center">AI training graphical representation</h1>
  <p align="center">
    Python-Unity pipeline that transforms dry numerical data into engaging 3D object animations within a Unity environment    <br />
    <br />
    <br />
  </p>
</div>



<!-- TABLE OF CONTENTS -->
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#project-description">Project description</a> </li>
      <ul>
        <li><a href="#the-challenge">The challenge</a></li>
        <li><a href="#built-with">Built with</a></li>
        <li><a href="#how-does-it-work">How does it work</a></li>
      </ul>
    <li><a href="#scenes-in-the-project">Scenes in the project</a></li>
      <ul>
        <li><a href="#base-template">Base template</a></li>
        <li><a href="#energai-smart-water-grid-project-implementation">EnergAI: Smart water grid project implementation</a></li>
      </ul>
    <li><a href="#future-applications-and-usage">Future applications and usage</a></li>
    <li><a href="#how-to-install-and-run">How to install and run</a></li>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#running">running</a></li>
      </ul>
    <li><a href="#how-to-use">How to use</a></li>
    <ul>
        <li><a href="#understand-the-code">Understand the code</a></li>
        <li><a href="#what to edit">What to edit</a></li>
    </ul>
  </ol>



# Project description

## The challenge

This project tackles a fundamental challenge in AI development: the tedium associated with analyzing vast amounts of numerical training data.
Traditionally, developers rely on poring over spreadsheets and charts, a process that can be time-consuming and hinder the intuitive grasp of complex relationships.
This project proposes a novel solution: a Python-Unity pipeline that transforms dry numerical data into engaging 3D object animations within a Unity environment.
Here's why:
* Replace static numbers with dynamic objects, allowing developers to absorb information more readily and efficiently.
* Visualizations can highlight intricate patterns and correlations within the data that might be easily missed in numerical representations.
* The ability to interact with the visualizations within Unity can further empower developers to explore the data in a more dynamic and engaging way.
 
This project seeks to revolutionize the way AI developers interact with training data, fostering a more efficient and insightful development process.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Built with

 ![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)
 ![Python](https://img.shields.io/badge/python-3670A0?style=for-the-badge&logo=python&logoColor=ffdd54)
 ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## How does it work?

The setup of the streamlined architecture for data exchange consists of the following components:
* Unity Project: The primary application where the object to be updated resides.
* C# Script: Attached to the aforementioned object within the Unity scene. This script acts as a server, listening for data from the Python script.
* Python Script: This script functions as a client. It reads data from a CSV file, processes it to identify relevant information, and transmits the selected data to the Unity application.

The Python script parses the CSV file, extracting and filtering the pertinent data.
The C# script serves as a listener, awaiting data transmission from the Python client.
Upon receiving the data, the C# script employs the received information to update the designated object within the Unity scene .
This approach facilitates real-time communication and dynamic object updates within the Unity environment, driven by the data processing capabilities of the Python script.
<p align="right">(<a href="#readme-top">back to top</a>)</p>


# Scenes in the project

## Base template

In the initial phase of this project, the objective was to establish a foundational environment. This environment prioritizes ease of modification and manages data exchange between Python and Unity. Additionally, it enables the manipulation of object positions. 
The overarching goal is to provide a reusable template. This template streamlines the development process by pre-configuring the communication aspects, allowing developers to concentrate solely on minor adjustments to the 3D environment for optimal data integration.

The project setup is designed to be straightforward and user-friendly. Developers can initiate the VR tour experience by launching the Unity program and entering "play mode" (achieved by pressing the play button within the editor interface). This action triggers the activation of a TCP server within the Unity environment. 
This server remains in a listening state, awaiting an incoming event.
Subsequently, the developer can execute the Python script. This script, for enhanced flexibility, can be stored in any desired location on the developer's computer, independent of the Unity project directory. Once initiated, the Python script commences the process of transmitting the chosen data to the Unity application. The developer can then observe the object within the VR environment updating in real-time as the data stream is received.

The developer's primary interaction with the codebase involves two key areas. Within the Python script, modifications can be made to the section responsible for selecting the data to be transmitted. Additionally, the format of the data can be adjusted if necessary to ensure compatibility with the trained model being employed. On the Unity side, the developer can focus on customizing the object manipulation logic within the C# code. This customization allows for tailoring the behavior of the object based on the specific needs of the project, including the names and quantities of the data elements being received.

## EnergAI Smart water grid project implementation

Following the development of the core environment, the next stage involved adapting the basic template to represent a more intricate scenario. This scenario aimed to visualize an AI training process relevant to a project undertaken by a colleague. Her project focused on training a model to work with temperature and steam data. To facilitate this, I constructed a virtual chemistry lab environment. The environment featured four glass thermometers, each representing a crucial data value for visualization. The filling level of each thermometer scaled dynamically based on the received data. Additionally, text boxes were implemented to display the corresponding data name and its associated value. Data transmission occurred in a row-by-row manner, iterating through a CSV file and sending each row sequentially.

https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/1e248bc8-22c9-4468-ab21-1937c008a589

# Future applications and usage

The future vision for this project entails enhancing the Unity environment for user customization through the development of a dedicated editor plugin. This plugin will cater to AI developers with expertise in Python, potentially lacking experience or possessing only rudimentary knowledge of Unity and C#. The editor plugin will empower them to modify and personalize the environment without requiring direct interaction with C# code or manipulation of 3D objects.

The plugin would provide a comprehensive suite of visual editing tools within the Unity editor, allowing users to personalize various aspects of the environment without writing code:

**Object Spawning and Prefab Management:**
* Drag-and-drop prefabs (pre-configured 3D objects) from the asset library into the environment scene.
* Position and manipulate objects using intuitive tools like gizmos, snapping, and alignment features.
* Set object properties through visual inspectors, defining attributes relevant to training (e.g., physics, materials, textures).

**Environment Composition and Layouts:**
* Pre-built environment templates to serve as starting points or inspiration.
* Procedural environment generation tools based on user-defined parameters (e.g., number of objects, object distributions, spatial constraints).
* In-scene editing tools for modifying terrain, adding lighting, and setting ambient effects.

**Automated Tasks and Code Generation:**
* The plugin can automate repetitive tasks based on user-defined parameters:
  * Populating the environment with objects based on distributions or patterns.
  * Generating variations of the environment for training diversity.
* The plugin can optionally generate minimal C# code under the hood to bridge the gap between visual editing and the underlying Unity functionalities. This generated code would be transparent to the user and wouldn't require manual editing.

# How to install and run

## Prerequisites
* <a href="https://unity.com/download"> Unity Hub </a>
* <a href="https://unity.com/releases/editor/whats-new/2022.3.10#installs"> Unity Editor 2022.3.10f1 or higher </a>
* <a href="https://www.python.org/downloads/release/python-3124/">Python 10 or higher</a>
* <a href="https://pandas.pydata.org/docs/getting_started/install.html">Pandas 2.2  </a>
* For any compatibility problem, my current working set up is Python 3.12.4, Pandas 2.2.2, Unity Editor 2022.3.10f1 and my packages list is:
  * blinker==1.7.0
  * click==8.1.7
  * colorama==0.4.6
  * filelock==3.9.0
  * Flask==3.0.2
  * fsspec==2023.4.0
  * itsdangerous==2.1.2
  * Jinja2==3.1.2
  * MarkupSafe==2.1.3
  * mpmath==1.3.0
  * networkx==3.2.1
  * numpy==1.26.4
  * pandas==2.2.2
  * pillow==10.2.0
  * python-dateutil==2.9.0.post0
  * pytz==2024.1
  * six==1.16.0
  * sympy==1.12
  * torch==2.2.0+cu118
  * torchaudio==2.2.0+cu118
  * torchvision==0.1.6
  * typing_extensions==4.8.0
  * tzdata==2024.1
  * Werkzeug==3.0.1

    
## Installation

1. Install the <a href="https://unity.com/download">Unity Hub </a> 
2. Install the recommented Unity Editor version through the hub, if not available anymore, use <a href="https://unity.com/releases/editor/whats-new/2022.3.10#installs">this link </a>
3. Install <a href="https://www.python.org/downloads/release/python-3124/">Python 3.12.4 </a>
4. Install Pandas packages
    ```sh
     python -m pip install pandas==2.2.2
     ```
5. Clone the repo
   ```sh 
   git clone https://github.com/FabrizioDeFiore/ReadmeTest.git
   ```
   
<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Running


| To run this project, locate the directory you just cloned into your unity hub and open the project | Locate the Project tab (if you can't find, use the toolbar on the top and go under Window > General > Project) and make sure you are running the scene BaseTemplate (Assets > Scenes > BaseTemplate) |
| :---:  | :---: |
| <img src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/ee63c679-96f0-4b43-ae6c-8d149d24f74e"  width="500" height="250">  | <img src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/67a6a476-7062-418e-b351-44aa48a73f49"  width="500" height="250"> |

| Open both the C# Listener and Python Client (Assets > Scripts > Client.py & Listener.cs) | And make sure the socket reference is the same and is free in your machine, and the localhost is correct|
| :---:  | :---: |
| <img src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/9b2653d1-3ac6-48a1-a655-5db1184f28bb"  width="500" height="250">  | <img src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/c5bd5f08-1caa-4692-8cac-fd53a9d98f1f"  width="500" height="250"> |


You can now start the application, run the "Server" first (the C# script) by clicking on the play button in the editor (top of the screen)

The next and last step is to run the "Client" (the python script), make sure that your csv file is in the same directory of your python script (the .py and the .csv can be stored anywhere in your machine, not only in the unity project directory, but the .cs has to be in there!) 
Once you are done you should see something like this:

https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/3e2230ab-9c1b-4cbf-aa86-29c865757ad6


<p align="right">(<a href="#readme-top">back to top</a>)</p>


# How to use

## Understand the code
The current setup provides a high degree of control for developers. By offering direct access to the Python script, C# script, and Unity environment, developers have the flexibility to deeply customize and personalize the project to their specific needs.
This level of access fosters a strong understanding of the project's inner workings, which can be valuable for troubleshooting and advanced modifications.

While this approach offers significant advantages, future development aims to further enhance user-friendliness and streamline development, by the development of a unity editor plugin. This plugin will empower Python developers to focus solely on the Python script.
The plugin will leverage a click-and-drag interface to handle logic within the Unity environment and C# script, eliminating the need for developers to delve into these areas. This approach minimizes the learning curve, allowing them to contribute efficiently without acquiring additional skillsets.

In the immediate term, if developers require prompt access to the project and the ability to make modifications, a comprehensive understanding of the project's underlying structure is paramount.

### Python client
This code acts as a stand-in for real sensors, creating a stream of data that mimics real-time sensor readings. It reads pre-recorded sensor data from a CSV file 

```py 
# Read data from CSV using pandas
simulated_data = pd.read_csv("YourFileName.csv")
```

The script defines a list of data stream names (data_stream_names), representing different sensor measurements we want to transmit (e.g., "CHPTemp1"). You'll need to update this list based on the actual data you want to send from the csv file, the names in the script have to match the column names.

```py 
# Define data stream names (modify these based on your actual stream names)
data_stream_names = ["CHPTemp1", "LoopTemp1", "Stoom", "CHPTemp1SP_Pred"]
```

It establishes a network connection using a socket to the Unity application running on the same machine (localhost) at a specified port.
This creates a communication channel between the simulated data source and the Unity application.

```py 
# HOST and PORT for connection (same as before)
HOST = '127.0.0.1'  # localhost
PORT = 25002
with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
  s.connect((HOST, PORT))
```

The code iterates through each row of the loaded data (excluding the header row) using pandas' iterrows function. Each row represents a single timestep of sensor readings.

```py 
  for index, row in simulated_data.iterrows():
    if index == 0:  # Skip the header row
      continue
```

For each timestep, it constructs a single string to represent all the sensor readings at that moment. It loops through the defined data stream names and retrieves the corresponding data point value from the current row in the CSV data

```py 
    data_string = ""
    for stream_name in data_stream_names:
      if stream_name in row.index:  # Check if name matches index (column name)
        data_point = row[stream_name]  # Access value by column name (index)
      else:
        # Handle missing column (optional)
        data_point = "NA"  # Or a default value

      data_string += f"{stream_name} {data_point}\n"  # Use f-string for formatted string
```

The constructed string containing all the combined sensor readings for that timestep is then sent to the Unity application using the established socket connection. The string is encoded in UTF-8 format before transmission 
```py 
    s.sendall(data_string.encode('utf-8'))
    print(f"Sent: {data_string}")  # Print sent data for debugging
```

<h4>Output:</h4>

```sh 
CHPTemp1 70.571
LoopTemp1 77.12464
Stoom 0.0527349753492881
CHPTemp1SP_Pred 73.03
```

### C# server
The server script focuses on establishing a smooth connection with the Python client and efficiently processing the received data:

**Data Reception:**
* The script listens for incoming connections on a specified port (default 25002).
* When a client connects, it creates a thread to handle receiving data.
* It continuously reads incoming data as byte streams.
* The received data is decoded into strings using UTF-8 encoding.
  
![c#DataReception](https://github.com/FabrizioDeFiore/AI-Training-Python-Unity-Visual-Environment/assets/78561254/79de4563-d84a-4565-b985-4511ca428fac)

**Data Parsing:**
* The received string is split into lines.
* Each line is expected to follow a specific format: "data_stream_name data_point".
* It extracts the data stream name (e.g., "CHPTemp1") and the data point value (e.g., a temperature).
* It validates the data format and attempts to convert the data point to a float.
  
![c#DataParsing](https://github.com/FabrizioDeFiore/AI-Training-Python-Unity-Visual-Environment/assets/78561254/3cb0d98c-1eb7-4078-8bd2-ba6a26ce4b28)

**Data Queuing:**
* Based on the data stream name, the script enqueues the parsed data point into a separate queue.
* This allows for handling different data streams independently.
  
![c#DataQuequing](https://github.com/FabrizioDeFiore/AI-Training-Python-Unity-Visual-Environment/assets/78561254/d5865d27-ca47-49bd-aec8-04456f568ab4)

**Data Processing:**
* Every frame, the script checks each data queue.
* If data is available in a queue, it dequeues the value.
* It normalizes the data point to a value between 0 and 1 (specific normalization factors applied for some streams).
* It calculates the Y position of a corresponding object using the CalculateYPosition function (likely linear interpolation).
* It updates the object's position and scale based on the calculated Y position and normalized data value.
* It updates text elements in the scene to display the raw data and potentially converted values.
  
![c#DataProcessing](https://github.com/FabrizioDeFiore/AI-Training-Python-Unity-Visual-Environment/assets/78561254/3a8868c3-ee9d-4355-b78e-c916be872ae4)

## What to edit
Here's what you'll need to edit every time you want to send data to Unity from a different CSV file:

**Data Source (CSV File):**
* Update the file path in both the C# and Python code to point to your new CSV file containing the sensor data.
  * In C#, this might involve modifying a string variable holding the file path.
  * In Python, you'll likely change the argument passed to `pd.read_csv` to specify the new file name.

**Data Stream Names (C# Only):**
* Modify the data_stream_names list in your C# code to match the actual column names (data stream names) present in your new CSV file.
* The Python code doesn't require this step since it retrieves data stream names directly from the CSV file headers (using pandas indexing).

**Data Handling (Optional):**
* If your new CSV file has a different structure or data format compared to the original, you might need to adjust the data parsing logic in both C# and Python.
  * In C#, this could involve modifying regular expressions used for splitting data lines or handling potential errors during data conversion.
  * In Python, you might need to adapt how you access data points from the CSV rows based on column names or data types.



<p align="right">(<a href="#readme-top">back to top</a>)</p>




