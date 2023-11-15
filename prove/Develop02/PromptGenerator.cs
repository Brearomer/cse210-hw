public class PromptGenerator
{
    // ATTRIBUTES (Class Variables)
    public List<string> _prompts = new()
    {
        "Prompt 1...",
        "another prompt...",
        "last prompt..."
    };
    public Random rng = new();

    // METHODS (Class Functions)
    //  (ACCESS TYPE) (RETURN TYPE) (NAME)(PARAMETERS){}

    public string GetRandomPrompt()
    {
       int index = rng.Next(_prompts.Count);
       return _prompts[index];
    }
}