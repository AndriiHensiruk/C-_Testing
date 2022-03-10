using System;
using System.Collections.Generic;


namespace blok2_task4
{
    class Message
    {
        public int OwnIndex { get; set; }
        public int ParentIndex { get; set; }
        public string TextMessage { get; set; }
        public string Answer { get; set; }
        public string Author { get; set; }
        public double Time { get; set; }

    }

    class Chat
    {
        public List<Message> messages { get; set; } = new List<Message>();
    
        public void SerchMessage(string author)
        {
            Message found = messages.Find(item=>item.Author==author);
            Console.WriteLine("Searched message " + author+": ");
            Console.WriteLine("\t"+found.OwnIndex+" "+found.Author+" "+found.TextMessage+" "+found.Answer+" "+found.Time);

        }

        public void SortMessage()
        {
            messages.Sort((message1, message2)=>message1.Time.CompareTo(message2.Time));
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat();
            chat.messages.Add(new Message()
            {
                OwnIndex = 1,
                ParentIndex = 1,
                Author = "Tom",
                TextMessage = "werqtqoitjo jhj",
                Time = 14.40,
                Answer = "dsfgsf sdfgfd fsdg"
            });

            chat.messages.Add(new Message()
            {
                OwnIndex = 2,
                ParentIndex = 1,
                Author = "Anton",
                TextMessage = "werqtqoitjo jhj",
                Time = 10.20,
                Answer = "dsfgsf sdfgfd fsdg"
            });

            chat.messages.Add(new Message()
            {
                OwnIndex = 3,
                ParentIndex = 1,
                Author = "Ana",
                TextMessage = "werqtqoitjo jhj",
                Time = 14.00,
                Answer = "dsfgsf sdfgfd fsdg"
            });

            chat.messages.Add(new Message()
            {
                OwnIndex = 4,
                ParentIndex = 1,
                Author = "Yana",
                TextMessage = "werqtqoitjo jhj",
                Time = 9.40,
                Answer = "dsfgsf sdfgfd fsdg"
            });

            Console.WriteLine("Boobs customer appeals");
            foreach (Message message in chat.messages)
                Console.WriteLine("\t"+message.OwnIndex +" "+message.Author +" "+ message.TextMessage +" "+ message.Time);

            chat.SortMessage();
            Console.WriteLine("Sorted list");
            foreach (Message message in chat.messages)
                Console.WriteLine("\t"+message.Time+" "+message.OwnIndex + message.Author + message.TextMessage +" "+message.Answer );

            Console.WriteLine("Enter a name for the Author");
            string name = Console.ReadLine();
            chat.SerchMessage(name);
        
       
        }
    }
}
