using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date) {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void EditEntry(string newPrompt, string newResponse) {
        _prompt = newPrompt;
        _response = newResponse;
    }

    public void Display(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string FormatForFile(){
        return $"{_date}|{_prompt}|{_response}";
    }
}