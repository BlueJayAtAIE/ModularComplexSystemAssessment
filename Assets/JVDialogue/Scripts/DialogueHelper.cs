﻿namespace JVDialogue
{
    public class DialogueHelper
    {
        // This class stores datatypes and settings for the entire dialogue system.
        // Make any additions necessary, but be sure to not remove anything! 

        // -------------------------------------- UNITY --------------------------------------
        // This is the enum used in determining what profile emotions characters can display.
        // The character's emotions will automatically update when an addition is made here.
        public enum EmotionState { Neutral, Happy, Sad, Angry };

        // This is used in determining how many profile sprites/character slots
        // the overall dialogue system attempts to use.
        public static int profileNumber = 5;


        // -------------------------------------- EDITOR --------------------------------------
        // When pressing "New Textbox" in the editor, a copy of the previous textbox is made rather than 
        // a completely blank slate.
        public static bool populateByDuplicating = true;

        // If set to true, the console will send warnings during playtime when the Fallback and 
        // Emotion Sprites are a character are unset. You may set this to false to prevent console 
        // warnings when you intend on having instances of characters displaying no profile.
        public static bool missingEmotionProfileWarnings = true;
    }
}
