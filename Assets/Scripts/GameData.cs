using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public static string[] descriptions =
    {
        "You emerge from a large purple door into a very snowy and cold forest.\vIt is extremely silent with only the sound of your feet scrunching on the snow.\vThere is one path cut alongside all of the trees\vWhat do you do?", 
        "Nothing happens... Except for a loud crunching sound ahead.\vWill you sit here and give up, or will you go to investigate?", 
        "You trudge forward. If anyone is going to get you out of this place it's you!\vAs you walk along the path, you notice a very large stick on the floor.\vIt is the perfect size to use as something to defend yourself if you so chose to.\vWhat do you do?", 
        "You look closer at the stick, there isn't much to note about it.\vIt probably fell off of the tree besides it.\vAnyone would be jealous of how swordlike this stick is. Tough-looking branch you'd say, someone smaller might find it too heavy to pick up.", 
        "You grab the stick from the ground, and tear it apart with your hands with a satisying *scrunch*\vAlthough perhaps you could have used this, you feel like some stress has been relieved.", 
        "You continue forward. You come across a bridge with bars that are more like pillars with how easily you could slip past them.\vSuddenly you hear footsteps behind you-\vYou see a skeleton person wearing a blue jacket approach you.\v\"You don\'t seem like you\'re from around here huh?\" The skellie says in a deep rattly voice.\vYou don't know much about this person but you're fight or flight instincts are making this situation feel tense.", 
        "Your body is filled with adrenaline from seeing a talking skeleton, your body feels tense and like it can react faster. What do you decide to do?", 
        "You swiftly strike at the skeleton with the stick you foudnd earlier already in your hands. Your strike lands with a *splash* sound.\v You stumble backwards in disbelief, the skeleton is bleeding, how? You are terrified.\v The skeleton looks down confused.\v\"Oh-\" The skeleton opens it's blue jacket to reveal a spilled ketchup bottle.\v\"Huh, you are interesting...\" the skeleton says.\vYou blink, and the skeleton is suddenly gone. You reflect on your actions.", 
        "With nothing else around you, you try to punch the skeleton, you miss as it sidesteps your slow attack.\vYou trip and fall straight on your face.\v\"I'm too lazy to deal with this.\"\vYou scramble back to your feet and the skeleton is gone. You reflect on your actions.", 
        "...", 
        "You reach into your pockets, and pull out a-\vKetchup bottle?\vThe skeletons eyes somehow non literally light up.\vYou reluctantly offer the bottle as a peace offering. The skelton glady accepts.\v\"My name is Sans. Sans the skeleton. What's your story?\"\vYou have a good feeling from this outcome.",
        "...",
        "You turn around.. And bolt out of there. \"I'm out of here\" you mutter under your breath.\vYou can't help but feel like you missed out on something in the back of your head.\vIt doesn't matter anymore, you just want to get through whatever the future holds.",
        "You think about telling the skeleton you don't want to fight, but not having said anything to it, you flake out.\vWhat will you do now?",
        "You tell the skeleton you don't want to fight it.\v\"Huh? Fight? I was never trying to fight you, I'm too lazy for that.\" The skeleton says.\vYou feel your body relax.\v\"Hey kiddo, My name is Sans. Sans the skeleton. What's your story?\"\vYou have a good feeling from this outcome.",
        "You tell the skeleton a bone pun that you made up on the spot.\vThe skeleton gives a good chuckle.\v\"That was a good one kiddo.\" \v\"My name is Sans. Sans the skeleton. What's your story?\"\vYou feel at ease, the skeleton doesn't seem to be a threat to you. You feel good about this outcome.",
        "You let yourself fall upon the floor, this is too much for you.\vYou know what they say, if you ever get lost in the wild, then stay in one place and wait for someone to rescue you\v Someone will come right?",
        "You pick up the stick and grasp it firmly in your hand.\vIt feels good in your hands.",
        "You take a closer look at the skeleton. It is wearing slippers that you for some reason can't tell if are pink or white, you decide not to think about it further.\vIt is looking at you seemingly intruiged and confused by your presence.\vThe way he holds himself and how it\'s clothes look make you think it is very laid-back and lazy. The jacket is frilly and has ketchup stains on it.",
        "With a lack of creativeness (ahem, writer\'s block), you converse with the skeleton about the weather.\vIt seems pleased, with the ice broken, perhaps you could calm the tension in the air somehow?",
        "You threaten to poke the skeleton where it's eyes should be.\vA couple of seconds pass and all you get is a slight frown from the skeleton.\vYou feel like your threat was pathetic."
    };

/*    public static string[,] options =
    {
        {"Option 00", "Option 01", "Option 02", "Option 03" },
        {"Option 10", "Option 11", "Option 12", "Option 13" },
        {"Option 20", "Option 21", "Option 22", "Option 23" },
        {"Option 30", "Option 31", "Option 32", "Option 33" },
        {"Option 40", "Option 41", "Option 42", "Option 43" },
        {"Option 50", "Option 51", "Option 52", "Option 53" },
        {"Option 60", "Option 61", "Option 62", "Option 63" },
        {"Option 70", "Option 71", "Option 72", "Option 73" },
        {"Option 80", "Option 81", "Option 82", "Option 83" },
        {"Option 90", "Option 91", "Option 92", "Option 93" },
        {"Option 100", "Option 101", "Option 102", "Option 103" },
        {"Option 110", "Option 111", "Option 112", "Option 113" }
    }; */

    public static string[][] options =
    {
        new string[]{"Do Nothing", "Investigate", "Yell For Help"}, // Start Room | 0 - > 1, 2
        new string[]{"Give Up", "Investigate"}, // If Yell Or Do Nothing Room 1 - > 16, 2
        new string[]{"Pick Up", "Ignore", "Investigate", "Break"}, // If Investigate | Room 2 - > 3, 4, 5, 17
        new string[]{"Pick Up", "Ignore", "Break"}, // Investigates Stick | Room 3 - > 4, 5, 17
        new string[]{"Continue Forward"}, // Breaks Stick | Room 4 - > 5
        new string[]{"Start Encounter"}, // Pre-Encounter | Room 5 - > 6
        new string[]{"Fight", "Act", "Items", "Mercy"}, // Encounter | Room 6 - > 7, 8, 9, 10, 11
        new string[]{"Reset", "Quit Game"}, // Fought With Stick (Ending) | Room 7
        new string[]{"Reset", "Quit Game"}, // Fought Without Stick (Ending) | Room 8
        new string[]{"Check", "Talk", "Joke", "Threaten"}, // Act Menu | Room 9 - > 18, 19, 15, 20
        new string[]{"Reset", "Quit Game"}, // Items Chosen (Ending) | Room 10
        new string[]{"Spare", "Flee"}, // Mercy Chosen | Room 11 - > 12, 13, 14
        new string[]{"Reset", "Quit Game"}, // If Flee (Ending) | Room 12
        new string[]{"Fight", "Act", "Items", "Mercy"}, // If Spare no talk | Room 13 - > 7, 8, 9, 10
        new string[]{"Reset", "Quit Game"}, // If Spare talked (Ending) | Room 14
        new string[]{"Reset", "Quit Game"}, // If joked (Ending) | Room 15
        new string[]{"Reset", "Quit Game"}, // If Gave Up (Ending) | Room 16
        new string[]{"Next"}, // If Picked Up Stick | Room 17 - > 5 (Sets hasStick to true)
        new string[]{"Next"}, // If Checked | Room 18 - > 6
        new string[]{"Next"}, // If Talked | Room 19 - > 6
        new string[]{"Next"} // If Threats | Room 20 - > 6
    };
}