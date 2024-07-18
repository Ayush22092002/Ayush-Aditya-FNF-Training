# Git Commands:
#### Configuration of Git:
git config: Configures Git settings, like user name and email. Useful for setting up your identity on a new system.
```
git config --global user.name "Your Name"
git config --global user.email "your_email@example.com"
```

#### Starting and Cloning Git Repositories. 
- git init. 
- git clone [url]

#### Changes to the Repository.
- git status: Shows the status of changes as untracked, modified, or staged.
- git add [file]: Adds a file to the staging area, making it ready for commit.
- git commit -m "commit message": Commits the staged changes to the repository with a descriptive message.

#### Branching and Merging
- git branch: Lists all local branches. When used with -a, it shows all branches.
- git branch [branch-name]: Creates a new branch.
- git checkout [branch-name]: Switches to the specified branch.
- git switch [branch-name]: A newer alternative to git checkout for switching branches.
- git merge [branch]: Merges the specified branch into the current branch.

#### Updating to the Central Repo
- git push [alias] [branch]: Uploads all local branch commits to the remote repository.
- git pull [alias] [branch]: Fetches and merges changes on the remote server to your working directory.
- git fetch [alias]: Fetches all the changes from the remote repository but does not merge them.

#### Inspection and Comparison.
- git log: Displays the commit history.
- git diff: Shows the differences not yet staged.
- git diff --staged (or --cached): Shows the differences between the staging area and the latest version.

#### Undoing Changes
- git checkout -- [file]: Discards the changes in the working directory.
- git restore [file]: A newer command to discard changes in the working directory.
- git reset [file]: Unstages the file, but preserves its contents.
- git commit --amend: Modifies the most recent commit.
- git revert [commit]: Creates a new commit that undoes the changes from a previous commit.

End of the Git Commands