# Voicevox4net
"Voicevox4net" is a class library that calls the Voicevox_Engine API on dotnet

## Overview
- Call Voicevox_Engine API.
- audio_query & synthesis.

## Usage
1. Add dll<br>
    Add the dll to your project
2. Add using<br>
    Add the following description
    ```
    using Voicevox4net;
    ```
3. Make Instance<br>
    Create an instance
    ```
    VoicevoxAPI voicevox = new VoicevoxAPI("server ip", "server port");
    ```
4. If you want to specify the download folder<br>
    The default is the current directory.
    ```
    voicevox.DownloadPath = "path";
    ```

5. Specify the speaker and synthesize text into speech. Save in wav format.
    ```
    await voicevox.Synthesis("file name", "text", true, speakerId);
    ```