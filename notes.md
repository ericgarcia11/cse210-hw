## Version Control System (VCS, like GIT) = A version control system, or VCS, tracks the history of changes as people and teams collaborate on projects together.
Check this link to learn more about VCS -> https://docs.github.com/en/get-started/using-git/about-git

* use "git add" and the complete directory name, (case matters) or just '.' to my current file - always to add the current file to stage area (area de preparacao).
* use "git status" to see if my file is on the stage area or not.
* use "git commit -m "comment here"" (where 'm' = comment) to add a comment to my update.
* use "git push" to push my updates to repository on Github.

- OBS.: if I saved something wrong, like a mistake, I can use:
    - git restore -staged directory_name
    - git status (optional)

- OBS.: In a normal workflow, I would use just:
    - git add .
    - git commit -m "any comment here"
    - git push
    - git status (optional)