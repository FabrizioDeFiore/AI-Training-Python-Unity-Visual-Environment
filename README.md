<a name="readme-top"></a>

<a><img alt="Static Badge" src="https://img.shields.io/badge/1.0.2-maker?style=for-the-badge&logo=github&logoColor=white&label=version&color=lightblue"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/11%2F06%2F2024-maker?style=for-the-badge&logo=clockify&logoColor=white&label=last%20edited&color=violet"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/python-maker?style=for-the-badge&logo=python&logoColor=red&label=language&labelColor=white&color=red"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/c%23-maker?style=for-the-badge&logo=c%23&logoColor=green&label=language&labelColor=white&color=green"></a>
<a href="https://www.linkedin.com/in/fabrizio-de-fiore/"><img alt="Static Badge" src="https://img.shields.io/badge/linkedin%20-maker?style=for-the-badge&logo=linkedin&logoColor=white&label=check%20out%20my&color=blue"></a>



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
    <li>
      <a href="#project-description">Project description</a>
      <ul>
        <li><a href="#built-with">Built with</a></li>
        <li><a href="#how-does-it-work">How does it work</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
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

* ![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)
* ![Python](https://img.shields.io/badge/python-3670A0?style=for-the-badge&logo=python&logoColor=ffdd54)
* ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

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


## What's in the project?

### Base template

In the initial phase of this project, the objective was to establish a foundational environment. This environment prioritizes ease of modification and manages data exchange between Python and Unity. Additionally, it enables the manipulation of object positions. 
The overarching goal is to provide a reusable template. This template streamlines the development process by pre-configuring the communication aspects, allowing developers to concentrate solely on minor adjustments to the 3D environment for optimal data integration.

The project setup is designed to be straightforward and user-friendly. Developers can initiate the VR tour experience by launching the Unity program and entering "play mode" (achieved by pressing the play button within the editor interface). This action triggers the activation of a TCP server within the Unity environment. 
This server remains in a listening state, awaiting an incoming event.
Subsequently, the developer can execute the Python script. This script, for enhanced flexibility, can be stored in any desired location on the developer's computer, independent of the Unity project directory. Once initiated, the Python script commences the process of transmitting the chosen data to the Unity application. The developer can then observe the object within the VR environment updating in real-time as the data stream is received.
The developer's primary interaction with the codebase involves two key areas. Within the Python script, modifications can be made to the section responsible for selecting the data to be transmitted. Additionally, the format of the data can be adjusted if necessary to ensure compatibility with the trained model being employed. On the Unity side, the developer can focus on customizing the object manipulation logic within the C# code. This customization allows for tailoring the behavior of the object based on the specific needs of the project, including the names and quantities of the data elements being received.

### EnergAI: Smart water grid project implementation

Following the development of the core environment, the next stage involved adapting the basic template to represent a more intricate scenario. This scenario aimed to visualize an AI training process relevant to a project undertaken by a colleague. Her project focused on training a model to work with temperature and steam data. To facilitate this, I constructed a virtual chemistry lab environment. The environment featured four glass thermometers, each representing a crucial data value for visualization. The filling level of each thermometer scaled dynamically based on the received data. Additionally, text boxes were implemented to display the corresponding data name and its associated value. Data transmission occurred in a row-by-row manner, iterating through a CSV file and sending each row sequentially.

ADD VIDEO 

## Future applications and usage

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

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/67a6a476-7062-418e-b351-44aa48a73f49" width="800" height="500"> </p>

Open both the C# Listener and Python Client (Assets > Scripts > Client.py & Listener.cs)

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/9b2653d1-3ac6-48a1-a655-5db1184f28bb" width="800" height="500"> </p>

And make sure the socket reference is the same and is free in your machine, and the localhost is correct

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/c5bd5f08-1caa-4692-8cac-fd53a9d98f1f" width="800" height="500"> </p>

You can now start the application, run the "Server" first (the C# script) by cliccking on the play button in the editor (top of the screen)

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/db64b3de-1bc1-4260-998a-7b0ae771b13e" width="800" height="500"> </p>

The next and last step is to run the "Client" (the python script), make sure that your csv file is in the same directory of your python script (the .py and the .csv can be stored anywhere in your machine, not only in the unity project directory, nut the .cs has to be in there!) 
Once you are done you should see something like this:

https://github.com/FabrizioDeFiore/ReadmeTest/assets/78561254/3e2230ab-9c1b-4cbf-aa86-29c865757ad6




<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
# Roadmap

- [x] Add Changelog
- [x] Add back to top links
- [ ] Add Additional Templates w/ Examples
- [ ] Add "components" document to easily copy & paste sections of the readme
- [ ] Multi-language Support
    - [ ] Chinese
    - [ ] Spanish

See the [open issues](https://github.com/othneildrew/Best-README-Template/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
# Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
# License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
# Contact

Your Name - [@your_twitter](https://twitter.com/your_username) - email@example.com

Project Link: [https://github.com/your_username/repo_name](https://github.com/your_username/repo_name)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
# Acknowledgments

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

* [Choose an Open Source License](https://choosealicense.com)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Malven's Flexbox Cheatsheet](https://flexbox.malven.co/)
* [Malven's Grid Cheatsheet](https://grid.malven.co/)
* [Img Shields](https://shields.io)
* [GitHub Pages](https://pages.github.com)
* [Font Awesome](https://fontawesome.com)
* [React Icons](https://react-icons.github.io/react-icons/search)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
