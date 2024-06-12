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
    <li><a href="#what's-in-the-project">What's in the project</a></li>
      <ul>
        <li><a href="#base-template">Base template</a></li>
        <li><a href="#EnergAI:-Smart-water-grid-project-implementation">EnergAI: Smart water grid project implementation</a></li>
      </ul>
    <li><a href="#Future-applications-and-usage">Future applications and usage</a></li>
    <li><a href="#How-to-install-and-run">How to install and run</a></li>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#running">running</a></li>
      </ul>
    <li><a href="#how-to-use">How to use</a></li>
    <ul>
        <li><a href="#understand-the-code">Understand the code</a></li>
        <li><a href="#basic-template-editing">Basic template editing</a></li>
        <li><a href="#chemistry-lab-template">Chemistry lab template editing</a></li>
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


# What's in the project?

## Base template

In the initial phase of this project, the objective was to establish a foundational environment. This environment prioritizes ease of modification and manages data exchange between Python and Unity. Additionally, it enables the manipulation of object positions. 
The overarching goal is to provide a reusable template. This template streamlines the development process by pre-configuring the communication aspects, allowing developers to concentrate solely on minor adjustments to the 3D environment for optimal data integration.

The project setup is designed to be straightforward and user-friendly. Developers can initiate the VR tour experience by launching the Unity program and entering "play mode" (achieved by pressing the play button within the editor interface). This action triggers the activation of a TCP server within the Unity environment. 
This server remains in a listening state, awaiting an incoming event.
Subsequently, the developer can execute the Python script. This script, for enhanced flexibility, can be stored in any desired location on the developer's computer, independent of the Unity project directory. Once initiated, the Python script commences the process of transmitting the chosen data to the Unity application. The developer can then observe the object within the VR environment updating in real-time as the data stream is received.

The developer's primary interaction with the codebase involves two key areas. Within the Python script, modifications can be made to the section responsible for selecting the data to be transmitted. Additionally, the format of the data can be adjusted if necessary to ensure compatibility with the trained model being employed. On the Unity side, the developer can focus on customizing the object manipulation logic within the C# code. This customization allows for tailoring the behavior of the object based on the specific needs of the project, including the names and quantities of the data elements being received.

## EnergAI: Smart water grid project implementation

Following the development of the core environment, the next stage involved adapting the basic template to represent a more intricate scenario. This scenario aimed to visualize an AI training process relevant to a project undertaken by a colleague. Her project focused on training a model to work with temperature and steam data. To facilitate this, I constructed a virtual chemistry lab environment. The environment featured four glass thermometers, each representing a crucial data value for visualization. The filling level of each thermometer scaled dynamically based on the received data. Additionally, text boxes were implemented to display the corresponding data name and its associated value. Data transmission occurred in a row-by-row manner, iterating through a CSV file and sending each row sequentially.

https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/1e248bc8-22c9-4468-ab21-1937c008a589

# Future applications and usage

The future vision for this project entails enhancing the Unity environment for user customization through the development of a dedicated editor plugin. This plugin will cater to AI developers with expertise in Python, potentially lacking experience or possessing only rudimentary knowledge of Unity and C#. The editor plugin will empower them to modify and personalize the environment without requiring direct interaction with C# code or manipulation of 3D objects.

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

To run this project, locate the directory you just cloned into your unity hub and open the project

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/ee63c679-96f0-4b43-ae6c-8d149d24f74e" width="800" height="500" > </p>

Locate the Project tab (if you can't find, use the toolbar on the top and go under Window > General > Project) and make sure you are running the scene BaseTemplate (Assets > Scenes > BaseTemplate)

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/67a6a476-7062-418e-b351-44aa48a73f49" width="800" height="450"> </p>

Open both the C# Listener and Python Client (Assets > Scripts > Client.py & Listener.cs)

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/9b2653d1-3ac6-48a1-a655-5db1184f28bb" width="800" height="450"> </p>

And make sure the socket reference is the same and is free in your machine, and the localhost is correct

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/c5bd5f08-1caa-4692-8cac-fd53a9d98f1f" width="800" height="400"> </p>

You can now start the application, run the "Server" first (the C# script) by clicking on the play button in the editor (top of the screen)

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/db64b3de-1bc1-4260-998a-7b0ae771b13e" width="800" height="500"> </p>

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
We'll keep the Python script concise and focused. Given the project's target audience of Python developers, we anticipate a smooth understanding of this component. This allows us to dedicate more time to exploring the intricacies of other areas if needed.

The initial portion of the script, following the imports, focuses on managing the connection details and CSV file reference. This section acts as the project's central configuration hub, allowing developers to easily personalize the experience.
Here's what you can modify:
* Host and Port: Specify the desired connection destination by adjusting the host address and port number.
* CSV File Path: Provide the path to your custom CSV file containing the data.
* Targeted Column: Select the specific column from the CSV file that you want to iterate through.

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/cfd96654-4ace-4b15-81e1-21e427974f5a" width="800" height="250"> </p>

The second half of the script is designed for minimal developer intervention, assuming the desired logic for processing the CSV file remains consistent. 
As long as the data extraction logic aligns with your project's requirements, no direct code edits are necessary within this section.
* The red-highlighted portion manages the initial server connection and subsequent data transmission, handling these crucial steps efficiently.
* The yellow-highlighted section takes care of iterating through each row of your chosen column(s) and transforming the data into the desired output format (as exemplified below)
  
<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/b5128c1e-315a-4a18-922e-cc24d48baf03" width="800" height="600"> </p>

<h4>Output:</h4>

```sh 
CHPTemp1 70.571
LoopTemp1 77.12464
Stoom 0.0527349753492881
CHPTemp1SP_Pred 73.03
```

### C# server

The initial portion of the server script focuses on managing the references to the objects in the 3D environment, the connections, and the data streams. These elements can be customized based on your training data and environment : 
* Object References: This section allows you to define references to the objects you want to update within your Unity scene. These references can include transforms (components controlling position, rotation, and scale), UI text elements (for displaying data stream names and values), and string references (used for data formatting).
* Data Queues: This section configures queues that temporarily store incoming data before displaying it in-game. This buffering mechanism ensures a smooth visual experience by preventing overwhelming data streams.
  <br>
  <br>
Here's what you can edit:
* Transforms: Assign references to the objects you want to visually update in your Unity scene.
* TMP_Text: Configure references to the UI text elements that will display data stream names and values.
* Strings and Queues: Define enough string references to match the number of columns you want to read from your CSV file (strings are used for data formatting and queues for data storage).<br>
Note: Connection references can be ignored as they don't require modification.

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/b42be4af-7f2b-43b1-9cbc-104cd2074a25" width="350" height="600"> </p>

The second half of the server script focuses on establishing a smooth connection with the Python client and efficiently processing the received data: <br>
The Start() function takes the lead by initializing the connection with the client, ensuring a reliable communication channel. <br>
The receive_data_function plays a crucial role. <br>
It accepts the connection, retrieves data streams, and performs essential transformations:
* Stream Splitting: Incoming data strings are meticulously divided, separating the data stream name from the actual data value for each column.
* Queue Updates: The processed data is then strategically placed in the corresponding queue, ensuring orderly storage and retrieval for later display within the game.

Here's where customization comes in (Highlighted Snippet): <br>
This section allows you to tailor the queues according to your data streams. <br>
You can modify the number of queues and adjust their names to perfectly match your project's requirements.

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/50ff1ebd-9c11-45e8-bc6c-5434d2a5ef5a" width="450" height="700"> </p>

### Unity editor
## Basic template editing

## Chemistry lab template editing


# Contact


<p align="right">(<a href="#readme-top">back to top</a>)</p>




