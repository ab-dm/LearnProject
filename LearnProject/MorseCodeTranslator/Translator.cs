using System;
using System.Text;
using static LearnProject.MorseCodeTranslator.MorseCodes;

namespace LearnProject.MorseCodeTranslator
{
    public static class Translator
    {
        public static string TranslateToMorse(string message)
        {
            StringBuilder messageMorseBuilder = new StringBuilder();
            WriteMorse(CodeTable, message, messageMorseBuilder);
            return messageMorseBuilder.ToString();
        }

        public static string TranslateToText(string morseMessage)
        {
            StringBuilder textMessageBuilder = new StringBuilder();
            WriteText(CodeTable, morseMessage, textMessageBuilder);
            return textMessageBuilder.ToString();
        }

        public static void WriteMorse(char[][] codeTable, string message, StringBuilder morseMessageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            else
            {
                message = message.ToUpper(System.Globalization.CultureInfo.CurrentCulture);
            }

            if (codeTable is null || morseMessageBuilder is null)
            {
                throw new ArgumentNullException(nameof(codeTable), "one of the arguments is null");
            }

            foreach (var messageItem in message)
            {
                int i = 0;
                while (i < codeTable.Length)
                {
                    if (messageItem == codeTable[i][0])
                    {
                        for (int j = 1; j < codeTable[i].Length; j++)
                        {
#pragma warning disable CA1062
                            morseMessageBuilder = codeTable[i][j] switch
                            {
                                '.' => morseMessageBuilder.Append(dot),
                                '-' => morseMessageBuilder.Append(dash),
                                _ => throw new NotSupportedException()
                            };
#pragma warning restore CA1062 // Validate arguments of public methods
                        }

                        morseMessageBuilder.Append(separator);
                        break;
                    }

                    i++;
                }
            }

            if (message.Length > 0)
            {
                morseMessageBuilder.Remove(morseMessageBuilder.Length - 1, 1);
            }
        }

        public static void WriteText(char[][] codeTable, string morseMessage, StringBuilder messageBuilder, char dot = '.', char dash = '-', char separator = ' ')
        {
            if (morseMessage is null)
            {
                throw new ArgumentNullException(nameof(morseMessage));
            }

            if (messageBuilder is null)
            {
                throw new ArgumentNullException(nameof(messageBuilder));
            }

            if (codeTable is null)
            {
                throw new ArgumentNullException(nameof(codeTable));
            }

            StringBuilder textmMessageBuilder = new StringBuilder();

            for (int i = 0; i < morseMessage.Length; i++)
            {
                if (morseMessage[i] == dot)
                {
                    textmMessageBuilder.Append('.');
                }
                else if (morseMessage[i] == dash)
                {
                    textmMessageBuilder.Append('-');
                }
                else if (morseMessage[i] == separator)
                {
                    textmMessageBuilder.Append(' ');
                }
            }

            string[] morseBilder = textmMessageBuilder.ToString().Split(' ');

            foreach (var itemMorseBilder in morseBilder)
            {
                for (int i = 0; i < codeTable.Length; i++)
                {
                    string temp = new string(codeTable[i][1..]);

                    if (itemMorseBilder == temp)
                    {
                        messageBuilder.Append(codeTable[i][0]);
                        break;
                    }
                }
            }
        }
    }
}
