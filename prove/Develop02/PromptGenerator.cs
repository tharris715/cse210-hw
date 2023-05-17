using System;
using System.Collections.Generic;

public class PromptGenerator {
    List<string> prompts = new List<string> {"What was your favorite part of today?", "What would you redo today if you could?", "What event from today would you like to share with your parents?", "Was there anything unusual about what happened today?", "What was the biggest news event you heard about today?", "What did you do today to become more Christlike?", "Did your children do anything funny or noteworthy today?"};

    Random random = new Random();

    static int GenerateRandomNumber(Random random)
    {
        return random.Next(0, 6); // Generates a random number between 1 and 7 (inclusive)
    }

    public string Display() {
        return prompts[GenerateRandomNumber(random)];
    }
}
