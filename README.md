# WLSXX Wrestling League Simulator

Since it's nearly impossible to find this game now, I've added one to this project. I've looked all over the internet for a version that contains all of the WWF wrestlers from that time. There was one, but it seems to have not survived time. If by chance you still have the wrestlers file for this, please, please get in touch (andyjonesx@gmail.com).

The two files are wls53.zip (original, no wrestlers, belts, etc), and "wls53-ihwa.zip" which is a file put online by a group that disbanded in 2004. It contains a number of wrestlers which will allow you to jump right in and play.


# This Project
This is a clone of WLS Wrestling League Simulator by Jamie Winquist released in 1995. 

20 years later and it's still a really fun game, except it doesn't work on Windows 8, and will work less and less as computers move on.

I'm embarking on a quest to clone the game as best as I can, adding a few new features, and making it all open source so it can live on!

For now it is called WLSXX, celebrating the 20th year of the last version WLS.

## An update

Life took over trying to do this (including twin daughters shortly after starting, and a couple of start ups). I have it as a personal challenge to one day recreate this in a different way (though by then I expect nobody at all will care). The scope would now be an online, API-based game where you can create your own league, and if you want, pitch your wrestlers against others online (including cross-league). I'd also try to make it completely open for people to make many changes and save their own "configs" including default moves, chances of them happening, damage, etc... because that means it can potentially always be evolving.

For now though, my next at least 3 years (as of Dec 2019) are locked up...





## Analysis of WLS

Notes: To navigate you press a button and press enter.


#1 : Intro screen with colour

#2 : Main Menu:

What do you want to do?
1) Create
2) View
3) Wrestle
4) Win/Loss Records
5) Delete
6) League Options
7) Edit
8) Train
9) Title Options
10) Import\Export
11) Exit
>_


#3 : Create

What would you like to create? 0 to exit
1) Wrestler
2) Tag Team
>_


#4 : Create Wrestler

How will this wrestler be controller?
1) Human
2) Computer

#5 : Create Wrestler 2
How will this wrestler be created?
1) Manually
2) Randomly

#6 : Create Wrestler 3
What is this wrestler's name? (Max of 25 characters)

#7 : Create Wrestler 4
What sex is this wrestler?
1) Male
2) Female

#8 : Create wrestler 5
What is this wrestler's height?
Feet
>_


Inches
>_

#9 : Create Wrestle 6
What is this wrestler's weight?
>_

#10 : Create Wrestler Move
In what situations can Andy Jones's first special move be done?
1) Locked up
2) Opponent is down
3) After throwing your opponenet into the ropes
4) After being thrown into the ropes
5) Opposite corners
6) Top rope with opponenet down
7) Top rope with opponenet up
8) Opponenet is stunned
>_

#11 : Create wrester move 2
What type of move will this be?
1) Regular
2) Submission

#12 : Create wrestler move 3
Please enter this move's name (Max of 25 characters)
>_

#13 : Create wrestler stats 1
Choose a primary speciality
1) Strength
2) Toughness
3) Conditioning
4) Intelligence
5) Cheating
6) Brawling
7) Technical
8) Mat Wrestling
9) Aerial
10) Quickness
11) Teamwork
>_

#14 : Create wrestler stats 2
Choose a secondary speciality
1) Strength
2) Toughness
3) Conditioning
4) Intelligence
5) Cheating
6) Brawling
7) Technical
8) Mat Wrestling
9) Aerial
10) Quickness
11) Teamwork
>_

#15: Create wrestler overview

Name: Andy Jones
Sex: Male
Height: 5'11"	Weight: 150 pounds

Strength: 		5	Toughness: 		2
Conditioning: 	3	Intelligence:	6
Cheating:		6	Brawling:		2
Technical:		4	Mat Wrestling:	3
Aerial:			5	Quickness:		1
Teamwork:		4


Move Name		Damage/Self		Chance		Pin		Submit		Code
Reverse DDT		14/ 0 - 25/ 0	70			73		0			1


What would you like to do?
1) Keep this wrestler
2) Return to the main menu
3) Reroll these stats


#16: Create wrestler end
Would you like to make another wrestler? (y/n)
>_

#17: View
What would you like to view? 0 to exit
1) Wrestler
2) Tag Team
3) League Leaders
>_

#18: View (List of wrestlers, then see #15 Create Wrester overview, without options)

#19: View Tagteam (list team)
Who do you want to view? 0 to exit (Page 1 of 1)

#20: View tagteam
The League of Legends (LowGun Smart & Andy Jones)
Human Controlled

Wins: 0		Losses: 1
Streak: 1 Match Losing

Victory Points per Match: 0

#21: View league leaders
Which category do you wish to view the eladers of? 0 to exit
1) Strength
2) Toughness
3) Conditioning
4) Intelligence
5) Cheating
6) Brawling
7) Technical
8) Mat Wrestling
9) Aerial
10) Quickness
11) Teamwork
>_

#21 : View league leaders strength (asks for how many to show, 1 to 5)
TOP 5 ACCORDING TO STRENGTH (centre aligned)
Name			Str	Tgh	Con	Int	Che	Brw	Tch	Mat	Aer	Qck	Tea
------------------------------------------------------------
1) LowGun Smart	6	5	2	2	0	6	6	5	2	4	0


#22 : Win/Loss Records
What would you like to look at? 0 to exit
1) Wrestlers
2) Tag Teams
>_

#23 : Win/Loss Tag Teams
What would you like to look at? 0 to exit
1) List-Ordered
2) List-All
3) Top Streaks
>_

#24 : Win/Loss List
TOP 2 (centered)
Name						Wins	Losses	Percentage	Rating
1) The League of Legends	0		1		0.0%		0.00
2) The Bouncing Nurse		1		0		100.0%		316.00

#25 : Edit WRestler
Here are the items you can change:
1) Name: The Executioner
2) Control: Human
3) Sex: Male
4) Height: 6'9 "
5) Weight: 567 pounds
6) Special Moves
7) V-Points: 0
8) Strength: 0
9) Toughness: 3
10) Conditioning: 0
11) Intelligence: 3
12) Cheating: 4
13) Brawling: 12
14) Technical: 5
15) Mat Wrestling: 6
16) Aerial: 8
17) Quickness: 3
18) Teamwork: 6
19) Exit and cancel changes
20) Exit and save changes
What would you like to change?
>_

#26) Title Options
What would you like to do? 0 to exit
1) Choose New Champ
2) Add Title
3) Retire Title
4) Change Title Name/Code
5) View Title History
>_

#27 Title Options Choose New Champ
Which type of belt? 0 to exit
1) Singles
2) Tag Team

#28 Choose Champ Singles
Which title would you like to change? 0 to exit
1) SuperDooperTitle (The Executioner)
2) SuperNooperTitle (VACANT)

#29 Choose Champ Singles 2
Who do you want to be the new champ? 0 to exit (Page 1 of 1)
1) The Executioner
2) 'Ambling' Eddie Robinson

#30 Add New Title
Which type of belt? 0 to exit
1) Singles
2) Tag Team

#31 Add New Title 2
What will title number 3 be called? (Max of 25 characters)
>_

What will the code of the title number 3 be? (Max of 2 characters)
>_

#32 View Title History
Which type of belt? 0 to exit
1) Singles
2) Tag Team

#32 View title singles
Which history do you want to view?
1) SuperDooperTitle (The Executioner)
2) SuperNooperTitle (VACANT)

#33 View Title history
1) The Executioner (Chosen) 	0 Matches
2) 'Ambling Eddie Robinson (Chosen)	0 matches

#34 Train
Who would you like to train?
1) Only Human controlled wrestlers
2) Only Computer contrlled wrestlers
3) All wrestlers

#35 Train (after selecting)
Here are The Executioner's current stats:
V-Points to spend: 0
1) Strength: 0		Cost: 250
2) Toughness: 3		Cost: 370
3) Conditioning: 0	Cost 250
4) Intelligence: 3	Cost 370
5) Cheating: 4		Cost 355
6) Brawling: 13		Cost 420
7) Technical: 5		Cost: 375
8) Mat Wrestling: 6	Cost: 395
9) Aerial: 8		Cost: 386
10) Quickness: 3	Cost: 335
11) Teamwork: 6		Cost: 395
12) New Special Move Cost: 500
Which stat would you like to train? 0 to exit
>_

The Executioner Doesn't have enough points to train Toughness.

||
0 = 250
1 = 290
2 = 330
3 = 
4 = 410
12 = 730

The Executioner's training was successful.
The Executioner's Strength rose from 0 to 1

The Executioner's training was successful.
The Executioner's Strength rose from 1 to 2

The Executioner's training was successful.
The Executioner's Strength rose from 2 to 4

The Executioner's training was successful.
The Executioner's Strength rose from 4 to 5

The Executioner's training didn't pay off.

The Executioner's training was successful.
The Executioner's Strength rose from 5 to 6

The Executioner's training was successful.
The Executioner's Strength rose from 6 to 7

The Executioner's training was successful.
The Executioner's Strength rose from 7 to 8

The Executioner's training was successful.
The Executioner's Strength rose from 8 to 9

The Executioner's training was successful.
The Executioner's Strength rose from 9 to 12


#36 Wrestle
What type of wrestling? 0 to exit
1) Single match
2) Entire card
3) Tournament

#37 Wrestle Singles

How would you like to play this match?
1) Human vs Human
2) Human vs Computer
3) Computer vs Comptuer -Slow
4) Computer vs Comptuer -Fast


#38 Wrestle singles type
What type of match would you like?
1) Regular
2) Submission
3) No DQ
4) Texas Death
5) 2 Out Of 3 Falls

Who do you want to be? 0 is random

Will 'Ambling' Eddie Robinson's SuperDooperTitle title be on the line in this match? (y/n)

#39 IN MATCH

This match is for the SuperDooperTitle Title!!!
The Executioner	0
'Ambling' Eddie Robinson	0

The Executioner and 'Ambling' Eddie Robinson are in the centre of the ring.

The Executioner, what do you want to do?
1) Lock Up
2) Punch
3) Kick
4) Take Down

'Ambling' Eddie Robinson, what do you want to do?
1) Lock Up
2) Punch
3) Kick
4) Take Down

The Executioner locks up with 'Ambling' Eddie Robinson.

Both Wrestlers are locked up.

<> , what do you want to do?
1) Push Towards Ropes
2) Push Towards Corner
3) Body Slam
4) Fireman's Carry
5) Small Package

<> , what do you want to do?
1) Push Towards Ropes
2) Push Towards Corner
3) Small Package

The Executioner tries to pick up <> but can't. <> pushes Exectioner into the ropes.

<> what do you want to do?
1) Punch

<> What do you want to do?
1) Irish Whip
2) Punch

Exectioner blocks <> punch and nails him back.

[health updated, 12]

'Ambling' Eddie Robinson grabs a leg and takes down The Executioner.

1) Get Up
2) Trip <>

<>
1) Stomp
2) Go To Top Rope
3) Pick <> Up

<> stomps on <> head.

1) Get Up
2) Trip <>

1) Stomp
2) Elbow Drop
3) Go To Top Rope
4) Leg Drop
5) Pick <> Up
6) Choke

<> Gets up.
<> is shoved into the corner by <>.

1) Ram <> Head To Turnbuckle
2) Punch
3) Whip <> Across the Ring

<> pounds on <> in the corner

[ Updated to blue ** 34 ].


