# Getting Started with GBGames

This guide will help you set up and run the GBGames project using cs.

## Prerequisites

 - .NET SDK 9.0 or later
   
 Make sure you have .NET SDK installed on your system. You can download it from the official website: [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

## Cloning the Repository

Clone the project repository using Git:

```sh
git clone https://github.com/AlexPlec/CSConsoleGames.git
```

Then, navigate into the project directory:

```sh
cd CSConsoleGames
```

## Step 1: Navigate to the GBGamesServer Directory

```sh
cd DedicateDB/GBGamesServer
```

## Step 2: Install Dependencies

Before running the project, you need to install the necessary dependencies. Use the following command to install them:

 ```sh
dotnet restore
```

## Step 3: Update Database

Before running the project, you need to update the necessary dependencies for database. Use the following command to install them:

```sh
dotnet ef database update
```

## Step 4: Run the Server

Once the dependencies are installed, you can start the project by executing the main script:

```sh
dotnet run
```

## Step 5: Navigate to the GBGames Directory

```sh
cd DedicateDB/GBGames
```

## Step 6: Install Dependencies

Before running the project, you need to install the necessary dependencies. Use the following command to install them:

 ```sh
dotnet restore
```

## Step 7: Update Database

Before running the project, you need to update the necessary dependencies for database. Use the following command to install them:

```sh
dotnet ef database update
```

## Step 8: Run the Server

Once the dependencies are installed, you can start the project by executing the main script:

```sh
dotnet run
```