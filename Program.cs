Random random = new Random(); // created a random number generator

bool playAgain = true; // boolean set to true if user wants to play again.
bool validPlay = true; // boolean for the while loop
bool validDiff = true; // boolean set to true for a while loop to check the user's difficulty input is valid
bool validNum = true; // boolean set to true for a while loop to check the user's number is valid
bool isNum1Ex;
bool isNum2Ex;

int userGuess; // int variable created to store the user's number guess
int userAttempts = 0; // int variable to store user's attempts it took to get the random number

string? userDiffAns; // user's difficulty answer
string? userPlayAgain; // user's play again answer
string? userNum1Ex;
string? userNum2Ex;

while (playAgain == true) // a while loop that loops when the user wants to play again.
{   
    userAttempts = 0; // resets the user's attempts to 0 IF they decides to repeats 

    while(validDiff == true) // a while loop to checks each difficulty the user inputs. If the input an invalid option it will loop back to the top of this while loop
    {
        Console.Write("//===========Choose what difficulty you want===========// \nEASY = (1 - 10)\nMEDIUM = (1 - 50)\nHARD = (1 - 100)\nEXTREME = Your numbers\nAnswer: "); // displays the difficulties you can choose
        userDiffAns = Console.ReadLine().ToUpper(); // converts user's input to all UPPERCASE

        if(userDiffAns == "EASY") // if the user inputs "EASY" run the code below
        {   
            bool boolEasy = true; // boolean declared in ONLY for if statment and is set to true
            int intEasy = random.Next(1, 11); // random.Next the numbers (1 - 11) the extra number is exclusive to 11 so it actually is (1 - 10)
            //userGuess = Convert.ToInt32(Console.ReadLine()); // (placed this here to see what the outcome would have been)
            //Console.Write("Enter a number! (1 - 10)"); // (placed this here to see what the outcome would have been)

            while(boolEasy) // a while loop that loops the user the random number and the users number until they get a match
            {
                Console.Write("Enter a number! (1 - 10): "); // display "Enter a number"
                //userGuess = Convert.ToInt32(Console.ReadLine()); // (placed this here to see what the outcome would have been)
                validNum = int.TryParse(Console.ReadLine(), out userGuess); // int.TryParse checks to see if the user inputs a actual number. if so it would be listed as TRUE if not it would be listed as FALSE and default the number to "0"

                if(validNum == false) // if the user's input is false
                {
                    Console.WriteLine("//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== YOUR ANSWER WILL DEFAULT TO 0 ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//"); // displays "ENTER A VALID NUMBER" and the users answer will default to "0"
                    boolEasy = true; // loops back to the beginning of the while loop boolEasy
                }

                if(intEasy < userGuess) // random number is less than the user's number
                {
                    Console.WriteLine("Your number " + userGuess + " is greater than the random number!"); // displays the user's number is higher than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else if(intEasy > userGuess) // random number is greater than the user's number 
                {
                    Console.WriteLine("Your number " + userGuess + " is less than the random number!"); // displays the user's number is lower than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else // else means the user's number equals the random number
                {
                    Console.WriteLine("You are correct! The number is " + intEasy + ". It took you " + userAttempts + " attempts to get the right number!"); // displays the user's number equals the random number and displays how many attempts it took to get the right number
                    boolEasy = false; // set to false after getting the right answer to exit the while loop
                }
            }
                    validDiff = false; // set to false to exit the validDiff while loop because the user entered a valid option
        }
        else if(userDiffAns == "MEDIUM") // if the user inputs "MEDIUM" run the code below
        {
            bool boolMedium = true; // boolean declared in ONLY for if statment and is set to true
            int intMedium = random.Next(1, 51); // random.Next the numbers (1 - 51) the extra number is exclusive to 51 so it actually is (1 - 50)

            while(boolMedium) // a while loop that loops the user the random number and the users number until they get a match
            {
                Console.Write("Enter a number! (1 - 50): "); // display "Enter a number"

                validNum = int.TryParse(Console.ReadLine(), out userGuess); // int.TryParse checks to see if the user inputs a actual number. if so it would be listed as TRUE if not it would be listed as FALSE and default the number to "0"

                if(validNum == false) // if the user's input is false
                {
                    Console.WriteLine("//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== YOUR ANSWER WILL DEFAULT TO 0 ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//"); // displays "ENTER A VALID NUMBER" and the users answer will default to "0"
                    boolMedium = true; // loops back to the beginning of the while loop boolMedium
                }

                if(intMedium < userGuess) // random number is less than the user's number 
                {
                    Console.WriteLine("Your number " + userGuess + " is greater than the random number!"); // displays the user's number is higher than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else if(intMedium > userGuess) // random number is greater than the user's number 
                {
                    Console.WriteLine("Your number " + userGuess + " is less than the random number!"); // displays the user's number is lower than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else // else means the user's number equals the random number
                {
                    Console.WriteLine("You are correct! The number is " + intMedium + ". It took you " + userAttempts + " attempts to get the right number!"); // displays the user's number equals the random number and displays how many attempts it took to get the right number
                    boolMedium = false; // set to false after getting the right answer to exit the while loop
                }
            }
                    validDiff = false; // set to false to exit the validDiff while loop because the user entered a valid option
        }
        else if (userDiffAns == "HARD") // if the user inputs "HARD" run the code below
        {
            bool boolHard = true; // boolean declared in ONLY for if statment and is set to true
            int intHard = random.Next(1, 101); // random.Next the numbers (1 - 101) the extra number is exclusive to 101 so it actually is (1 - 100)

            while(boolHard) // a while loop that loops the user the random number and the users number until they get a match
            {
                Console.Write("Enter a number! (1 - 100): "); // display "Enter a number"

                validNum = int.TryParse(Console.ReadLine(), out userGuess); // int.TryParse checks to see if the user inputs a actual number. if so it would be listed as TRUE if not it would be listed as FALSE and default the number to "0"

                if(validNum == false) // if the user's input is false
                {
                    Console.WriteLine("//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== YOUR ANSWER WILL DEFAULT TO 0 ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//"); // displays "ENTER A VALID NUMBER" and the users answer will default to "0"
                    boolHard = true; // loops back to the beginning of the while loop boolHard
                }

                if(intHard < userGuess) // random number is less than the user's number
                {
                    Console.WriteLine("Your number " + userGuess + " is greater than the random number!"); // displays the user's number is higher than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else if(intHard > userGuess) // random number is greater than the user's number 
                { 
                    Console.WriteLine("Your number " + userGuess + " is less than the random number!"); // displays the user's number is lower than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else // else means the user's number equals the random number
                {
                    Console.WriteLine("You are correct! The number is " + intHard + ". It took you " + userAttempts + " attempts to get the right number!"); // displays the user's number equals the random number and displays how many attempts it took to get the right number
                    boolHard = false; // set to false after getting the right answer to exit the while loop
                }
            }
                    validDiff = false; // set to false to exit the validDiff while loop because the user entered a valid option
        }
        else if(userDiffAns == "EXTREME") // if the user inputs "EXTREME" run the code below
        {   
            int minNum; // variable created for the user's minimum number
            int maxNum; // variable created for the user's maximum number
            bool boolEx = true; // boolean declared in ONLY for if statment and is set to true
            
            Console.Write("Enter your Minimum number: "); // displays "Enter your minimum number: "
            //minNum = Convert.ToInt32(Console.ReadLine()); // converts user's input into a int
            do // added this do while loop for number validation
            {
                userNum1Ex = Console.ReadLine();
                isNum1Ex = int.TryParse(userNum1Ex, out minNum);

                if(isNum1Ex != true)                            
                {
                    Console.Write("Please enter a valid minimum number: ");
                }
            }
            while(isNum1Ex != true);

            Console.Write("Enter your Max number: "); // displays "Enter your max number: "
            //maxNum = Convert.ToInt32(Console.ReadLine()); // converts user's input into a int
            do // added this do while loop for number validation
            {
                userNum2Ex = Console.ReadLine();
                isNum2Ex = int.TryParse(userNum2Ex, out maxNum);

                if(isNum2Ex != true)
                {
                    Console.Write("Please enter a valid maximum number: ");
                }
            }
            while(isNum2Ex != true);

            int intEx = random.Next(minNum, maxNum + 1); // random.Next the numbers the user inputs, the extra number (+1) is exclusive

            while(boolEx) // a while loop that loops the user the random number and the users number until they get a match
            {
                Console.Write($"Enter a number! ({minNum} - {maxNum}): "); // display "Enter a number"

                validNum = int.TryParse(Console.ReadLine(), out userGuess); // int.TryParse checks to see if the user inputs a actual number. if so it would be listed as TRUE if not it would be listed as FALSE and default the number to "0"

                if(validNum == false) // if the user's input is false
                {
                    Console.WriteLine("//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== YOUR ANSWER WILL DEFAULT TO 0 ==========//\n//========== ENTER A VALID RESPONSE ==========//\n//========== ENTER A VALID RESPONSE ==========//"); // displays "ENTER A VALID NUMBER" and the users answer will default to "0"
                    boolEx = true; // loops back to the beginning of the while loop boolEx
                }

                if(intEx < userGuess) // random number is less than the user's number
                {
                    Console.WriteLine("Your number " + userGuess + " is greater than the random number!"); // displays the user's number is higher than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else if(intEx > userGuess) // random number is greater than the user's number 
                {
                    Console.WriteLine("Your number " + userGuess + " is less than the random number!"); // displays the user's number is lower than the random number
                    userAttempts++; // tally the user's attempt by 1
                }
                else // else means the user's number equals the random number
                {
                    Console.WriteLine("You are correct! The number is " + intEx + ". It took you " + userAttempts + " attempts to get the right number!"); // displays the user's number equals the random number and displays how many attempts it took to get the right number
                    boolEx = false; // set to false after getting the right answer to exit the while loop
                }
            }       
                    validDiff = false; // set to false to exit the validDiff while loop because the user entered a valid option    
        }
        else // else the user enters a invalid option
        {
                    Console.WriteLine("//========== ENTER A VALID RESPONSE ==========//"); // displays "Enter a valid response"
                    validDiff = true; // set to true so it will loop back to enter a valid difficulty
        }

    }
        validPlay = true; // set to true in case the user wanted to play again after using the program the first time

        while(validPlay == true) // while loop created for the user inputing a valid playAgain option
        {
            Console.Write("Would you like to play again? (Y/N): "); // display "Would you like to play again? (Y/N)"
            userPlayAgain = Console.ReadLine().ToUpper(); // grabs user's input and converts it to UPPERCASE

            if (userPlayAgain == "Y") // if the user inputs "Y"
            {
                validPlay = false; // leave the validPlay loop
                playAgain = true; // starts the whole program over
                validDiff = true; // set back to true. if not it will constantly ask "Would you like to play again? (Y/N)"
            }
            else if (userPlayAgain == "N") // if the user inputs "N"
            {
                playAgain = false; // exits the playAgain loop and ends the program
                validPlay = false; // exits the validPlay loop
            }
            else
            {
                validPlay = true; // loops the validPlay loop until the user inputs a valid option 
                playAgain = false; // playAgain gets set to false so user can't loop back to the beginning of the 1st while loop
                Console.WriteLine(userPlayAgain + " is not a valid response. Please enter a valid response please."); // displays the invalid response and is asked to enter a valid response
            }
        }
}

Console.WriteLine("Thank you for playing!"); // after picking "N" display "Thank you for playing!"