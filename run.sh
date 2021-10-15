#!/bin/bash
dotnet test ./tests/tests.csproj && docker-compose up
