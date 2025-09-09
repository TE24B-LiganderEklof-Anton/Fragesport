static int WriteAndAwaitValidAnswer(string Text, string[] ValidAnswers)
{
    while (true)
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine(Text);
        for (int i = 0; i < ValidAnswers.Length; i++)
        {
            string Alternative = ValidAnswers[i];
            Console.WriteLine($"{i + 1}: {Alternative}");
        }
        string AnswerString = Console.ReadLine();
        int AnswerInt;
        bool AnswerIsInt = int.TryParse(AnswerString, out AnswerInt);
        if (AnswerIsInt && AnswerInt < ValidAnswers.Length + 1 && AnswerInt > 0)
        {
            //Console.WriteLine(AnswerInt);
            return AnswerInt - 1;
        }
        Console.WriteLine("That is not an option, please try again.");
    }
}

List<(string text, string[] answers, int correct)> questions = [];

questions.Add(("How tall is Mount Everest?", ["7998m","8849m", "8958m","9081m", "7889m"], 1));
questions.Add(("How long is the great wall of China?", ["12896km", "15825km", "36578km", "28765km", "21196km"], 4));
questions.Add(("Tokyo is the biggest city in the world. Roughly how many people live there?", ["17 million", "21 million","25 million", "28 million","37 milliom",], 4));

while (true)
{
    int points = 0;
    int questionamount = 0;
    for (int i = 0; i < questions.Count; i++)
    {
        string text = questions[i].text;
        string[] options = questions[i].answers;
        int answer = WriteAndAwaitValidAnswer(text, options);
        questionamount += 1;
        if (answer == questions[i].correct)
        {
            points += 1;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }
    int correctrate = points * 100 / questionamount;
    Console.WriteLine($"You got {correctrate}% of question correct");
    string againQuestion = "Would you like to try again?";
    string[] againChoices = ["Yes", "No"];
    int againAnswer = WriteAndAwaitValidAnswer(againQuestion, againChoices);
    if (againAnswer == 1)
    {
        break;
    }
    
}












