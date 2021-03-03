# Random File Picker

![GitHub Workflow Status (branch)](https://img.shields.io/github/workflow/status/EverAzureRest/randomFilePicker/Build/dev?label=devbuild&style=plastic)

![GitHub Workflow Status (branch)](https://img.shields.io/github/workflow/status/EverAzureRest/randomFilePicker/Build/main?label=build&style=plastic)

## About

A simple .NET core CLI program that simply scans all files in a target directory and opens a random file with it's registered file handler.

## Usage

```bash
randomFilePicker /path/to/files "<pattern>.ext"
randomFilePicker /mount/dir/media "*.txt"
randomFilePicker /home/myfiles/videos "this*.mp4"
```
