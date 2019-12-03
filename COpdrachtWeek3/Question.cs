using System;
using System.Collections.Generic;
using System.Text;

namespace COpdrachtWeek3
{
    class Question
    {

    }

    public void CheckAnswer() {

    }

    public static void presentQuestion(Question q) {
        q.display();
        Console.WriteLine("Your answer: ");
        String response = Console.ReadLine();
        Console.WriteLine(q.CheckAnswer(response));
    }
}
