## Nakon zavrsenog feature-a
- `git checkout -b naziv_grane`
- `git status` (opciono)
- `git add .`
- `git commit -m "Poruka"`
- `git push -u origin naziv_grane`

## Napraviti pull request sa svoje grane na main
razresiti konflikte
- na github-u
- lokano
    - `git checkout main`
    - `git pull`
    - `git checkout naziv_grane`
    - `git merge main`
    - razresiti konflikte kroz Visual Studio (Code)
    - `git status`
    - `git add .`
    - `git commit -m "Resolve merge conflicts"`
    - `git push`
    
merge pull request (kroz github)

## Pre rada na sledecem feature-u
- `git checkout main`
- `git pull`

