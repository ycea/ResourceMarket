using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMarket.Logic
{
    public class News
    {
        public Dictionary<string, string[]> allNews;
        public News() {
            allNews = new Dictionary<string, string[]>();
            allNews.Add("Oil", new string[]
            {
                "В средней Азии разгорелся новый военный конфликт.", // +Oil
                "Ряд государств приняло очередные меры по поддержке альтернативных источников энергии", // -Oil
                "Страны ОПЕК уменьшили добычу нефти", // +Oil
                "Ряд крупных нефтедобывающих компаний увеличило добычу нефти" //-Oil               
            });
            allNews.Add("Gold", new string[]
            {
                "Люди обеспокоены увеличением военных конфликтов по всему миру", // +Gold
                "ЦБ объявил о повышении процентной ставки", //-Gold
                "На фондовых рынках наблюдается всеобщий спад", // +Gold
                "На фондовых рынках наблюдается всеобщий подъем", // -Gold
                
            });
            allNews.Add("Iron", new string[]
{
                "Производственные предприятия увеличили объемы производств", //+Iron
                "Разработана более эффективная технология добычи металла", // -Iron
                "Главный экспортер стали сократил поставки из-за экологических требований", // +Iron
                "В автомобильном секторе наблюдается упадок производства", // -Iron
});
            allNews.Add("Food", new string[]
            {
                "У крупных поставщиков прогнозируют сезон засухи", // +Food
                "Ученые разработали новый вид зерна, обладающий устойчивостью к засухе и болезням", // -Food
                "Из-за войны  одной из крупных зерновых стран поставки зерна значительно осложнились", //+Food
                "Сельские хозяйства отмечают рекордную урожайность", // -Food
            }
            );

        }
        public (string news,int resourceType, int actionType) chooseRandomNews()
        {
            Random random = new Random();
            int choicenKeyInd = random.Next(0, allNews.Count);
            string choicenKey = allNews.Keys.ToList<string>()[choicenKeyInd];
            int choicenValue = random.Next(0, allNews.Count);
            return (allNews[choicenKey][choicenValue],choicenKeyInd, choicenValue);
        }
    }
}
