# Random File Picker

![GitHub Workflow Status (branch)](https://img.shields.io/github/actions/workflow/status/EverAzureRest/randomFilePicker/main.yml)

![Project License](https://img.shields.io/badge/license-MIT-blue)

## About

A simple .NET core CLI program that simply scans all files in a target directory and opens a random file with it's registered file handler.

## Build

```bash
dotnet build . --configuration Release
```

## Usage

```bash
randomFilePicker /path/to/files "<pattern>.ext"
randomFilePicker /mount/dir/media "*.txt"
randomFilePicker /home/myfiles/videos "this*.mp4"
```
