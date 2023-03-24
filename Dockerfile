# Use the official .NET Core SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory in the container
WORKDIR /app

# Copy the project file into the container
COPY . ./

# Restore the NuGet packages for the project
RUN dotnet restore ./src/Conekta.net/Conekta.net.csproj

# Copy the rest of the project files into the container
RUN dotnet restore ./src/Conekta.net.Test/Conekta.net.Test.csproj

RUN dotnet build
#RUN dotnet test ./src/Conekta.net.Test/Conekta.net.Test.csproj -c Release

# Build the project and generate a release-ready DLL
RUN dotnet publish ./src/Conekta.net/Conekta.net.csproj -c Release -f netstandard2.0 

# Build the project and generate a release-ready DLL
RUN dotnet publish ./src/Conekta.net/Conekta.net.csproj -c Release -f net6.0