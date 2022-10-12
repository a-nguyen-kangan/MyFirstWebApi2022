var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => AddTwoIntegers(2, 5));

// map a new get route to /add
app.MapGet("/add", () => AddTwoIntegers(9, 8));

// parameter routing
app.MapGet("/add/{input1}/{input2}", (int input1, int input2) => AddTwoIntegers(input1, input2));

app.MapGet("/sub/{input1}/{input2}", (int input1, int input2) => SubtractTwoIntegers(input1, input2));

app.MapGet("/charcount/{word1}/{word2}", (string word1, string word2) => TotalCharCount(word1, word2));

app.MapGet("/matchchar/{character}/{word}", (char character, string word) => CharMatchCount(character, word));

app.Run();

// function to add two integers together
int AddTwoIntegers(int num1, int num2) {
    int ans = num1 + num2;
    return ans;
}

// function to add two integers together
int SubtractTwoIntegers(int num1, int num2) {
    return num1 - num2; 
}

int TotalCharCount(string word1, string word2) {
    return word1.Length + word2.Length;
}

int CharMatchCount(char character, string word) {
    int matches = 0;
    foreach(char c in word) {
        if (character == c) {
            matches++;
        }
    }

    return matches;
}