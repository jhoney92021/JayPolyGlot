# jhoney's Git notes

### Quick Links

- [Home](../README.md)

# Getting Started with Git

Welcome to the world of version control! Git is a powerful tool that helps you track changes in your code, collaborate with others, and manage your project's history. Follow these steps to set up and use Git for your development projects.

## Step 1: Install Git

If you don't have Git installed on your machine, you can download and install it from the [official Git website](https://git-scm.com/downloads).

## Step 2: Configure Git

After installation, configure Git with your name and email. Open a terminal and run the following commands:

```bash
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

Replace "Your Name" with your actual name and "your.email@example.com" with your email address.

## Step 3: Create a New Repository

Navigate to your project folder and initialize a new Git repository with the following command:

```bash
git init
This command sets up a new Git repository in your project directory.
```

## Step 4: Add and Commit Changes

Add your files to the staging area using:

```bash
git add .
Commit the changes to the repository with:
```

```bash
git commit -m "Initial commit"
Replace "Initial commit" with a meaningful commit message.
```

## Step 5: Create a Remote Repository (Optional)

If you want to collaborate with others or store your code remotely, create a new repository on a platform like GitHub, GitLab, or Bitbucket.

Follow the platform's instructions to add a remote:

```bash
git remote add origin <remote_repository_url>
```

## Step 6: Push Changes

Push your committed changes to the remote repository:

```bash
git push -u origin master
```

Replace "master" with the name of your branch.

## Step 7: Pull Changes

If you're collaborating with others, pull the latest changes from the remote repository:

```bash
git pull origin master
```
