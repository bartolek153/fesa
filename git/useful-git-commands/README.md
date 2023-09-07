
# Git Commands Cheatsheet

## Basic Actions

```bash
# Overwrite last commit, without changing commit message
git commit -m <message> -a --amend --no-edit

# Undo last commit, keeping changes 
git reset --soft HEAD~1

# Undo last commit, DISCARTING ALL CHANGES (dangerous command)
git reset --hard HEAD~1
```

## Remote repositories

```bash
# Add remote repository, set a remote branch to upload and pushes it
git remote add origin <repo_url>
git branch -M main
git push -u origin main
```

## Logging

```bash
# See logs with a compact and 'tree perspective' style
git log --oneline --graph --all
```

## Tagging

```bash
# Tag a new version
git tag -a <tag> -m message
git push --tags
git fetch --tags
```

## Configs

```bash
# Create aliases
git config --global alias.<alias_name> <command>
```
