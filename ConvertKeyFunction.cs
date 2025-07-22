using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPadConsole_CodeTest
{
	public class ConvertKeyFunction
	{
        public string ConvertKeyInputToLetters(string keyPresses)
        {
            if (string.IsNullOrEmpty(keyPresses))
                return "";

            var result = new StringBuilder();
            char lastKey = '\0';
            int pressCount = 0;

            foreach (char currentKey in keyPresses)
            {
                if (currentKey != lastKey)
                {
                    AppendCharacter(result, lastKey, pressCount);

                    lastKey = currentKey;
                    pressCount = 1;
                }
                else
                {
                    pressCount++;
                }

                switch (currentKey)
                {
                    case '#':
                        AppendCharacter(result, lastKey, pressCount);
                        return result.ToString();

                    case '*':
                        if (result.Length > 0)
                        {
                            result.Length--;
                        }
                        lastKey = '\0';
                        break;

                    case ' ':
                        lastKey = '\0';
                        break;
                }
            }

            AppendCharacter(result, lastKey, pressCount);

            return result.ToString();
        }

        private void AppendCharacter(StringBuilder result, char lastKey, int pressCount)
        {
            if (lastKey == '\0')
                return;

            if (Keypad.Mappings.TryGetValue(lastKey, out string? mappedChars))
            {
                int index = (pressCount - 1) % mappedChars.Length;
                result.Append(mappedChars[index]);
            }
        }
    }
}
