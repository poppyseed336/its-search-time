
#################################
######### CONTENTS
#################################

A. BASICS
 a1. Introduction
 a2. About Search Time
B. RUNNING SEARCH TIME (Windows)
 b1. Prerequisites
 b2. Steps to run Search Time
C. TECH STACK

#################################
######### A. BASICS
#################################

## a1. Introduction

Hi - welcome to Search Time!
Thanks for taking the time to review this work sample.

This is a full stack app that allows a user to search items in a DB based on either their name, color, or both.
(The items themselves are arbitrary and random.)

## a2. About Search Time

Hi, I'm Lomax - my intent is to show a full stack app that I developed alone, using tools like Angular with ngrx and C# with ASP.Net.
The database is created using Entity Framework Core's code first approach, and thanks to Docker the db container persists data even after being stopped/restarted.
The search uses pagination to display ten items at a time, allowing the user to skip to nearby pages or jump to the first or last page.
There are solutions for front end tables available out there as libraries but in this instance I decided to create my own little custom table solution with pagination.

I hope tinkering around with my app is fun for you.

#################################
###### B. RUNNING SEARCH TIME (Windows)
#################################

## b1. Prerequisites

Please ensure the following are installed on your computer:
Docker Desktop
Docker CLI
Github CLI

## b2. Steps to run Search Time

1) Ensure Docker Desktop is running.
2) Run this in a command prompt: gh repo clone poppyseed336/its-search-time
3) In a command prompt, 'cd' into the root directory of the newly cloned repo, which will be named 'search-time'.
4) In this same command prompt, run this command: docker-compose up
5) After allowing the app time to build, look in Docker Desktop to verify that containers are running named 'back-end' and 'database-container'.
6) In a separate command prompt, 'cd' into the front end directory, which will be named 'search-time/search-time-front-end'.
7) In this second command prompt, run this command: 'ng serve'.
8) You're ready to use the app! In a browser navigate to http://localhost:4200

#################################
######## C. TECH STACK
#################################

git for version control
Docker for containerization
Angular for front end
Bootstrap for front end styling
rxjs for front end state management
C# with ASP.Net for back end
Entity Framework Core on back end for interactions with database
Honorable mention: TSQL for testing/toying with data using SQL Server Management Studio, though this app obviously doesn't display that
