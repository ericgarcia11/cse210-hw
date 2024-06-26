## Version Control System (VCS, like GIT) = A version control system, or VCS, tracks the history of changes as people and teams collaborate on projects together.
Check this link to learn more about VCS -> https://docs.github.com/en/get-started/using-git/about-git

* use "git add" and the complete directory name, (case matters) or just '.' to my current file - always to add the current file to stage area (area de preparacao).
* use "git status" to see if my file is on the stage area or not.
* use "git commit -m "comment here"" (where 'm' = comment) to add a comment to my update.
* use "git push" to push my updates to repository on Github.
*   

- OBS.: if I saved something wrong, like a mistake, I can use:
    - git restore -staged directory_name
    - git status (optional)

- OBS.: In a normal workflow, I would use just:
    - git add .
    - git commit -m "any comment here"
    - git push
    - git status (optional)


#### What is version control and why is it important?
One Version Control System (VCS) is a system responsible to record and manage the changes in a project, which is especially important in a project with different collaborators. 
There are many benefits in using an VCS, one example is that it prevents a collaborator's version from overlapping another, generating errors in the project.
To avoid this, you can use an VCS such as GIT, to each collaborator work with his own branch, without affect the main project, until they finish their updates, by using "git push" to update the main project (or repository) with their updated branch for example, and using "git status" to check the stage status always when is needed, to avoid errors on pushing updates.

#### What is abstraction and why is it important?
A man proves real intelligence when he got something hard to learn, and turns it in something easy to understand.
I could explain how to create a file with your inputs in a program line by line, even if it take you hours; however it is more  useful create a function or class to do it, and only explain you how to call that.
Basically, this is abstraction. Abstraction means take something extent and hard, eliminate the not essential, and let only the fundamentals characteristics remains.
This is really useful daily on programming, to optimize time, work, and to simplify them.
For example, once I created a code to add jobs into a resume. You could add one job with about 20 lines of code, but creating a class, it was made with more or less three. Assuming that you had created the job, just with "resume1._jobs.Add(job1);" the job would be added to the resume.
How would it happen? Doesn't matters, it works. We only need to understand what the function or class need, and what it do.

#### What is encapsulation and why is it important?
Imagine a medicine capsule. Why do we don't just get the drugs inside? One of the possible answers is that the responsibility of taking care the drugs inside the capsule, their composition, their purity are not us, but it is of drugs industry. Our responsibility is to use that object, as led by our doctor or drugs industry.
Similarly, in programming with classes, sometimes we will need to change the way the variables are handled (change theirs composition, purity, as drugs inside the capsule). Instead of letting anothers programs acess our variables, we can turn them private, and take care inside the class of all things regards the variables, alowing the anothers programns only using the begaviors we choose.
This is encapsulation. Is to hide the details about how we handle the variables, behaviors, constructors, and alowing others programns to acess only what we choose. This is not to punish others dev's, on the contrary, this is to help them, leeting them take care with what really matters, the class objective.
For example, in my program, I use one class called Scripture, which has a behavior to hide random words in the scripture. With only one line, like this "scriptureObject.HideRandomWords(wordsToHide);" we can hide this random words, and we only need to provide how much words we want to hide as an int variable. However, this behavior uses about 52 lines to perform this task, and also uses another class. How this task is completed does not matter to the main code. The task be completed is what really matters.

#### What is inheritance and why is it important?
Imagine work your entire life, and get a two properties. You have a son and you are not using one propertie. Why should him get another if he can use the one you are not using? Ok, there are a lot of reasons to do not using; but this is only an attepmt to illustrate that sometimes, despite not having to claim, in order to save re-work, the son can use things already done by the father.
Similarly, if I create an "Activity" class which have a name, description and duration; and later I need to create one "ReflectionActivity" class which will have name, description and duration attributes as well, but now with prompts and questions attributes, would not be really useful inherit the name, description and duration attributes, only giving prompts and questions attributes unto this last one?
This is inheritance in the programming concept.
When I create the ReflectionActivity, I can turn it in an Activity inheritor class by adding ": Activity" after the class name, like this: 
- Normal: "public class ReflectionActivity".
- inheritor: "public class ReflectionActivity : Activity". 

#### What is polymorphism and why is it important?
Imagine that you are a conductor of an orchestra and you want a C note. For the guitar players, they will need to put 3 fingers in some strings and parts of the guitar and use the other hand to play that strings; to piano players they will need to use +- 6 fingers above the piano keys, and others instrumental players will have another things to do, to reproduce a C note.
As your role is not to play each thing, but to conduct the entire orchestra, you don't need to lost time with each detail about how they do it; but what you need is to ask for that behavior, that sound, in some way that, even being differents instruments, all of them could make the sound by that asked.
Polymorphism is like this.
You need something from different situations, and you need to call them in the same way, but they should have different behaviors and sometimes difference displays. Polymorphism is the ability of something to have or to be displayed in more than one form.
For example, in my code this week, in a specific part, I need to save data into a file.
I have different kind of data to save from each class, and this would be a problem; but, as all of them are Goal inherits, making the function "GetStringRepresentation" virtual, I can override the inherited classes functions to save each data the way I need.
Basically doing this on parent class function:
-  public virtual string GetStringRepresentation()
And this on inherit classes function:
- public override string GetStringRepresentation()