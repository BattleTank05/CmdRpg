import random, time
have_sword = False
def chapter_one():
    print("Chapter 1: Adventure Village\n")
    start()
def sword_grab():
    print("You grabbed the sword.")
    have_sword = True
    spire()
def chapter_three():
    print("Chapter 3: The Cursed Lands\n")
    cursed_land()
def chapter_two():
    print("Chapter 2: The Mountains of Wyrmhaven\n")
    mountain()
def game_end():
    print("The dragon flew away, no longer heeding a call of darkness.\nYou have succesfully purged the land of evil!\nPlay again?")
    wincmd = input("1.) Yes\n2.) No\n")
    if wincmd == "1":
        start()
    elif wincmd == "2":
        quit()
def boss_kill():
    print("The beast snaps your spine in half, instantly killing you.\nGame Over\nPlay again?")
    kilcmd = input("1.) Yes\n2.) No\n")
    if kilcmd == "1":
        start()
    elif kilcmd == "2":
        quit()
def flee():
    print("You flee the tower.\nYou get lost in the foggy hills of the cursed lands.\nGame Over\nPlay again?")
    fleecmd = input("1.) Yes\n2.) No\n")
    if fleecmd == "1":
        start()
    elif fleecmd == "2":
        quit()
def bossbat():
    boss_alive = True
    health = 100
    boss_health = 10
    while boss_alive == True:
        bosscmd = input("1.) Hit the creature with your sword\n2.) Run away\n")
        if bosscmd == "1":
            print("You swing your sword.")
            ranbohit = random.randint(1, 2)
            if ranbohit == 1:
                print("You hit the beast!")
                boss_health -= 1
                if boss_health <= 0:
                    print("The creature screeches.\nHe dissapears in a puff of smoke.")
                    boss_alive = False
                    game_end()
                else:
                    boss_health = boss_health
            elif ranbohit == 2:
                print("The beast hits you!")
                health -= random.randint(5, 10)
                if health <=0:
                    boss_kill()
                else:
                    print(health)
        elif bosscmd == "2":
            flee()
def bat():
    if have_sword == True:
        bossbat()
    elif have_sword == False:
        boss_kill()
def room_check():
    print("There is a large sword leaning against the wall.")
    roocmd = input("1.) Grab it\n2.) Leave it alone\n")
    if roocmd == "1":
        sword_grab()
    elif roocmd == "2":
        spire()
def spire():
    print("A hulking black figure sits at a crude table.\nIt looks up at you with shining white eyes.\nIt prepares to obliterate you.")
    spicmd = input("1.) Fight\n2.) Check the room\n")
    if spicmd == "1":
        bat()
    elif spicmd == "2":
        room_check()
def whisper():
    print("You follow the whispering.\nIttakes you to a twisted spire.\nThere seems to be somenone - or something - inside.")
    wiscmd = input("1.) Go inside\n2.) Try to retrace your steps back to the portal\n")
    if wiscmd == "1":
        spire()
    elif wiscmd == "2":
        randirect()
def remb():
    print("You are in the cursed lands!")
    cursed_land()
def cursed_land():
    print("Strange twisty trees sway in the distance.\nYou hear a faint whispering.\nYou rember something about this place...")
    curcmd = input("1.) Follow the whipering\n2.) Try to remember where you are\n")
    if curcmd == "1":
        whisper()
    elif curcmd == "2":
        remb()
def villtalk():
    ranvilltalk = random.randint(1, 3)
    if ranvilltalk == 1 or ranvilltalk == 3:
        print("Hi adventurer! I'm glad you came. I've been hearing some strange tales about ... well never mind. Saria knows more than I do, you can find her at the tavern.")
        print("New Quest! Find and enter the tavern")
    elif ranvilltalk == 2:
        print("Hi adventurer! I'm glad you came. I don't know much about our current situation, but you can talk to the village lord. I bet he knows more than me.")
        print("New Quest! Find and enter the village lord's longhouse")
    village_square()
def lord():
    rantalk = "Oh! You're the new adventurer! We greatly thank you for coming on such short notice. We're having some trouble here in Adventure Village, you see. A dragon has moved into the old wyrm holes! Can you help us?"
    print(rantalk)
    print("New Quest! Find the dragon")
    vllhouse()
def vllhouse():
    print("You enter the village lord's longhouse.")
    vllcmd = input("1.) Talk to the village lord\n2.) Leave\n")
    if vllcmd == "1":
        lord()
    elif vllcmd == "2":
        village_square()
def torch():
    print("You don't have anything to light it with!")
    get_up()
def go_north():
    print("You travel north, directly disobeying the skeleton's orders.\nA swirling black portal awaits at the end of the passage.")
    norcmd = input("1.) Enter the portal\n2.) Try to go back to the dragon\n")
    if norcmd == "1":
        chapter_three()
    elif norcmd == "2":
        randirect()
def kick_skeleton():
    print("You kick the skeleton because it didn't give you any good information.\nIts bones crumble into dust.")
    newnewgu()
def newnewgu():
    newnewcmd = input("1.) Go north\n2.) Angrily kick the skeleton\n")
    if newnewcmd == "1":
        go_north()
    elif newnewcmd == "2":
        kick_skeleton()
def paper():
    print("""The paper says these words: "Do not come down here! You are not very smart to have come down here if you are reading this!Do not go north!I am being chased by a mejnhygvejhsagyjak..."\nThe words are illegible after this line.""")
    newnewgu()
def newgu():
    print("The skeleton appears to be completely dead.")
    newcmd = input("1.) Read the paper\n2.) Check the skeleton\n3.) Walk in a random direction\n")
    if newcmd == "1":
        paper()
    elif newcmd == "2":
        skeleton()
    elif newcmd == "3":
        randirect()
def randirect():
    print("You walk off in a random direction.\nYou eventually end up dying from lack of sleep.\nGame Over\nPlay again?")
    rancmd = input("1.) Yes\n2.) No\n")
    if rancmd == "1":
        start()
    elif rancmd == "2":
        quit()
def skeleton():
    print("You closely observe the skeleton.\nIt carries a peice of paper.")
    newgu()
def get_up():
    print("You stand up and look around.\nYou see a skeleton.")
    getcmd = input("1.) Check the skeleton\n2.) Walk in a random direction\n3.) Use your torch\n")
    if getcmd == "1":
        skeleton()
    elif getcmd == "2":
        randirect()
    elif getcmd == "3":
        torch()
def cont_hole():
    print("You trip and fall through a second hole.\nYou land heavily.\nYou start crying.")
    cohcmd = input("1.) Get up\n2.) Give up\n")
    if cohcmd == "1":
        get_up()
    elif cohcmd == "2":
        print("You eventually die of starvation.\nGame Over\nPlay again?")
        cocmd = input("1.) Yes\n2.) No")
        if cocmd == "1":
            start()
        elif cocmd == "2":
            quit()
def inventory():
    print("Torch (x1)\nPebble (x1)")
    down_hole()
def down_hole():
    print("You continue to explore the hole.\nIt seems to go on forever.")
    docmd = input("1.) Continue down the hole\n2.) Check your inventory\n3.) Go back and fight the dragon\n")
    if docmd == "1":
        cont_hole()
    elif docmd == "2":
        inventory()
    elif docmd == "3":
        fight()
def run_away():
    print("You barely escape, due to your superior speed.")
    runcmd = input("1.) Continue down the hole\n2.) Go back and fight the dragon\n")
    if runcmd == "1":
        down_hole()
    elif runcmd == "2":
        fight()
def fight():
    print("The dragon fries you to a crisp with its fiery breath.\nGame Over\nPlay again?")
    playcmd = input("1.) Yes\n2.) No\n")
    if playcmd == "1":
        start()
    elif playcmd == "2":
        quit()
def stats():
    print("Stats:\nHealth: 100\nStrength: -7\nSpeed: 10")
    dragon_walk()
def dragon_walk():
    print("You attempt to walk around the dragon.\nYou trip over it's tail.\nIt wakes up and looks at you.\nIt seems angry.")
    wacmd = input("1.) prepare to fight\n2.) See your stats\n3.) Run away\n")
    if wacmd == "1":
        fight()
    elif wacmd == "2":
        stats()
    elif wacmd == "3":
        run_away()
def dragon_slap():
    print("You slap the dragon.\nNothing happens.")
    dragon()
def dragon():
    print("The object appears to be the snout of a sleeping dragon.")
    dracmd = input("1.) Walk around the dragon\n2.) Slap the dragon\n")
    if dracmd == "1":
        dragon_walk()
    elif dracmd == "2":
        dragon_slap()
def darkness():
    print("You reach out into the darkness and feel ... something.")
    darkcmd = input("1.) Attempt to find out what the object is\n")
    if darkcmd == "1":
        dragon()
def exhole():
    print("You can't see anything down here!\nIt's too late to go back up.")
    exhcmd = input("1.) Reach out into the darkness\n2.) Scream and hope someone hears you\n")
    if exhcmd == "1":
        darkness()
    elif exhcmd == "2":
        print("""Your voice bounces of the walls and yells back at you, "Heeeelp!".\nNo one is near enough to hear your pitiful screams.""")
        exhole()
def holes():
    print("You arrive at one of the holes.\nIt smells musty and looks dark.")
    holcmd = input("1.) Explore the hole\n2.) Go somewhere else\n")
    if holcmd == "1":
        exhole()
    elif holcmd == "2":
        print("You chicken!")
        explore()
def mountain():
    print("After many days of travel, you arrive at a small mountain.\nVarious holes pocket one side.")
    mocmd = input("1.) Explore the holes\n2.) Go somewhere else\n")
    if mocmd == "1":
        holes()
    elif mocmd == "2":
        explore()
def areusure():
    print("Are you sure you want to leave?")
    leave = input("1.) Yes\n2.) No\n")
    if leave == "1":
        explore()
    elif leave == "2":
        village_square()
def explore():
    print("Where do you want to go?")
    excmd = input("1.) To the mountain\n2.) To the cursed lands\n3.) Back to the village\n")
    if excmd == "1":
        chapter_two()
    elif excmd == "2":
        print("You can't go there yet!")
        explore()
    elif excmd == "3":
        village_square()
def gossip():
    ran_gossip = random.choice(["I heard there's a new guy in town, you seen him yet?", "I heard there's a dragon living in the old wyrm holes.", "Have you heard of the new guy yet? They say he's an adventurer. Don't get much of those anymore."])
    print(ran_gossip)
    tavern()
def tavern():
    print("Welcome to the tavern!")
    tavcmd = input("1.) Ask the bartender about the latest gossip\n2.) Leave\n")
    if tavcmd == "1":
        gossip()
    elif tavcmd == "2":
        village_square()
def whoyou():
    ran_who = random.choice(["You're the new adventurer!", "I've never met you before!"])
    print(ran_who)
    village_square()
def village_square():
    print("You return to the village square.")
    village = input("1.) Leave the village\n2.) Find and enter the tavern\n3.) Find and enter the village lord's longhouse\n4.) Talk to a villager\n5.) Attempt to find out who you are by asking the person next to you\n")
    if village == "1":
        areusure()
    elif village == "2":
        tavern()
    elif village == "3":
        vllhouse()
    elif village == "4":
        villtalk()
    elif village == "5":
        whoyou()
def start():
    print("A long time ago, in a cottage somwhere over the great lake Ta'kumtil, a young boy named Fred was playing by the water. As Fred played by the lake, he heard hoofbeats down the beaten dirt path. It was an adventurer! A great adventurer with a gleaming sword and a shiny helmet. As the adventurer passed, a small pebble fell out of his bag. Fred immediately picked it up and kept it for the rest of his life.\n\nOne day, when Fred was a grown man, he heard of a land in peril. He decided to become an adventurer and save the village. When our unlikely adventurer passed through the gates of Adventure Village however, he tripped over a root and hit his head ...\n")
    print("You spawn in a small village square.\nThe bustle around is totally normal.\nYou wonder how you got here.")
    enviroment = input("1.) Find and enter the village tavern\n2.) Find and enter the village lord's longhouse\n3.) Talk to a villager\n4.) Attempt to find out who you are by asking the person next to you\n")
    if enviroment == "1":
        tavern()
    elif enviroment == "2":
        vllhouse()
    elif enviroment == "3":
        villtalk()
    elif enviroment == "4":
        whoyou()
chapter_one()