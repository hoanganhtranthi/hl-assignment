using Jokee.Data;
using Jokee.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokee.Service.ImpService
{
    public class JokeService : IJokeService
    {
        private readonly List<Joke> listJokes;
        public JokeService()
        {
            listJokes = new List<Joke>();
            listJokes.Add(new Joke { Id=1,Description= "A child asked his father, \"How were people born?\" So his father said, \"Adam and Eve made babies, then their babies became adults and made babies, and so on.\"\r\n\r\nThe child then went to his mother, asked her the same question and she told him, \"We were monkeys then we evolved to become like we are now.\"\r\n\r\nThe child ran back to his father and said, \"You lied to me!\" His father replied, \"No, your mom was talking about her side of the family.\"" });
            listJokes.Add(new Joke { Id = 2, Description = "Teacher: \"Kids,what does the chicken give you?\" Student: \"Meat!\" Teacher: \"Very good! Now what does the pig give you?\" Student: \"Bacon!\" Teacher: \"Great! And what does the fat cow give you?\" Student: \"Homework!\"\r\n\r\n" });
            listJokes.Add(new Joke { Id = 3, Description = "The teacher asked Jimmy, \"Why is your cat at school today Jimmy?\" Jimmy replied crying, \"Because I heard my daddy tell my mommy, 'I am going to eat that pussy once Jimmy leaves for school today!'\"" });
            listJokes.Add(new Joke { Id = 4, Description = "A housewife, an accountant and a lawyer were asked \"How much is 2+2?\" The housewife replies: \"Four!\". The accountant says: \"I think it's either 3 or 4. Let me run those figures through my spreadsheet one more time.\" The lawyer pulls the drapes, dims the lights and asks in a hushed voice, \"How much do you want it to be?\"" });
        }
        
        public Task<List<Joke>> GetJokees()
        {
            return Task.FromResult(listJokes.ToList());
        }
    }
}
