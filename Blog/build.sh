#!/usr/bin/env bash

dotnet publish -c Release -o out
docker build . -t blog