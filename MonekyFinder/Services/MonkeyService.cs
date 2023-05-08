using Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Services;
public class MonkeyService
{
        HttpClient httpClient;

        List<Monkey> monkeyList = new();
        
        public async Task<List<Monkey>> GetMonkeys()
        {
            if(monkeyList?.Count > 0)
                return monkeyList;

            var url = "https://montemagno.com/monkeys.json";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            return monkeyList;
        }

}

