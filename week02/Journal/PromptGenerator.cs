public class PromptGenerator
{

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0,10);
       


        String[] questions = new string[10];
        

        questions[0] = "Who was the most interesting person I interacted with today?";
        questions[1] = "What was the best part of my day?";
        questions[2] = "How did I see the hand of the Lord in my life today?";
        questions[3] = "What was the strongest emotion I felt today?";
        questions[4] = "How was I Christlike today?";
        questions[5] = "If I had one thing I could do over today, what would it be?";
        questions[6] = "What is something I am thankful for today?";
        questions[7] = "What brought me joy today?";
        questions[8] = "What is one song I kept singing today?";
        questions[9] = "What's 1 thing I want to remember today?";

        return questions[num];
        


        
    }
}