# WPF-Radio Project
Created a **3 tier radio application** with a *Data Layer*, *Business Layer* and a *GUI layer*

* Simple Radio with 5 channels that play the correct radio channels
* Plays a selected playlist

## Project Goal

The project goal was to create a simple 3 tier radio application with which could at a minimum play the radio and swap between 4  different channels. 

### MVP

* The application must be able to play the different channels
* The default channel should be channel one
* When the radio is off clicking the any channel should inform the user the radio is off
* Clicking play when the radio is off should inform the user that the radio is off
* When the radio is on and play is clicked, the radio should play channel 1

## All Functionalities

* Turn Off
* Turn On
* Channel Option
* Play
* Pause
* Volume Up/Down
* Playlist 
* Next song (Playlist function)
* Previous song (Playlist function)

### Class Diagram

![Class diagram](https://github.com/sarkerJ/WPF-RadioProject/blob/main/Images/Class%20Diagram.JPG)

## Instructions

* Once the **Radio is Turned ON**
  * You can press **Play** to play the **default channel** (channel 1)
  * You can **select a channel** of your choosing and **click Play to play it**
  * You can select **Playlist** to play a list of songs that have been **saved** under the given **file path** (A certain file)
    * Change the file path to your own file path and ensure the music file are type **.mp3** for them to found by the application
* If the **Radio is Off** you **cannot play anything** 

* **Turn OFF** button is to stop the radio entirely



##### Bugs

* Once the Playlist reaches the last song it will continue playing the song instead of starting from the first one again



#### Radio Off

![RadioOff](https://github.com/sarkerJ/WPF-RadioProject/blob/main/Images/RadioOff.JPG)

#### Radio On

![RadioOn](https://github.com/sarkerJ/WPF-RadioProject/blob/main/Images/RadioOn.JPG)

#### Radio On Playing - Channel 1

![PlayintChannel1](https://github.com/sarkerJ/WPF-RadioProject/blob/main/Images/RadioPlayingChannelOne.JPG)

#### Radio Playing- Playlist

![PlayingPlaylist](https://github.com/sarkerJ/WPF-RadioProject/blob/main/Images/RadioPlayingPlaylist.JPG)



