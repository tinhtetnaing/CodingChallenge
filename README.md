# Old Phone Keypad Console Application

Here is a .Net 7 console application of old phone keypad with alphabetical letters, a backspace
key, and a send.

## Description 

This program demostrats the letter mapping system in old keypad phones. Each button has a sequence of letter to represent and pressing multiple time to button 
enables to cycle the letter sequence which enables each button to represent more than on letter.

For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.

## Technologies Used

_ .Net 7 SDK
_ xUnit (for testing)

## Project Structure

/CodingChallenge.OldPhonePadConsoleApp
  ├── Program.cs
  └── OldPhonePadService.cs
/CodingChallenge.OldPhonePadTests
  └── OldPhonePadServiceTests.cs
README.md


## Steps of Run

### 1. Clone Repo
git clone 
cd 
### 2. Open the Solution
Open 'CodingChallenge' in Visual Studio
### 3. Build the Solution
Go to 'Build > Build Solution'
### 4. Run the Project
Press 'F5' or go to 'Debug > Start Debugging'

## Unit Tests
This project includes unit testing and this is the sample test case. You can test with any input string you desired.

```csharp
[Theory]
[InlineData("4433555 555666#", "HELLO")]
[InlineData("8 88777444666*664#", "TURING")]
[InlineData("227*#", "B")]
public void OldPhonePadService_OldPhonePad_ShouldReturnString(string input, string expected)
{
    var result = _service.OldPhonePad(input);
    Assert.Equal(expected, result);
}
```


## Running the Tests

### 1. Open Test Explorer
       Go to: Test > Test Explorer (or use Ctrl + E, T)

### 2. Build the Solution
       Build > Build Solution (or press Ctrl + Shift + B)

### 3. Run the Tests
        In the Test Explorer, click Run All to execute all tests.



