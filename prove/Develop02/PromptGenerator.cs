using System;
using System.Collections.Generic;

class PromptGenerator {
    private List<string> prompts;
    private Random rand;

    public PromptGenerator(List<string> prompts) {
        this.prompts = prompts;
        rand = new Random();
    }

    public string Display() {
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
