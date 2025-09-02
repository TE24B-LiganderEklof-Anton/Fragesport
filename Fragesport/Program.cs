static int WriteAndAwaitValidAnswer(string Text, string[] ValidAnswers)
{
    while (true)
    {
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
            Console.WriteLine(AnswerInt);
            return AnswerInt - 1;
        }
        Console.WriteLine("That is not an option, please try again.");
    }
}


List<(string text, string[] answers, int correct)> questions = [];

questions.Add(("textfråga", ["svar1", "svar2"], 1));
questions.Add(("textfråga", ["svar1", "svar2"], 1));
questions.Add(("textfråga", ["svar1", "svar2"], 1));

// for (int i = 0; i < questions[0].answers.Length; i++)
// {
//     System.Console.WriteLine(questions[0].answers[i]);
// }




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
    int correctrate = points / questionamount;
    Console.WriteLine("You got correctrate% of question correct");
    
}












