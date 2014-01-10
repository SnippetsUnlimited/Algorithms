using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Algorithms.Text.Bitap
{
    public class Bitap
    {
        public static int MatchExact(string text, string searchWord)
        {
            if (string.IsNullOrEmpty(searchWord))
            {
                return -1;
            }

            bool[] trace = new bool[searchWord.Length + 1];
            trace[0] = true;

            for (int x = 0; x < text.Length; x++)
            {
                for (int y = searchWord.Length; y >= 1; y--)
                {
                    trace[y] = trace[y - 1] && (text[x] == searchWord[y - 1]);
                }

                if (trace[searchWord.Length] == true)
                {
                    return x - searchWord.Length + 1;
                }
            }

            return -1;
        }

        // Maximum Word length 32 characters.
        public static int MatchExact32Bit(string text, string searchWord)
        {
            // there are 256 ASCII characters
            const int Char_Size = 256;
            const int Max_Size = 32;

            if (searchWord.Length > Max_Size)
            {
                throw new Exception("Length not supported");
            }

            if (string.IsNullOrEmpty(searchWord))
            {
                return -1;
            }

            UInt32 state_Mask = 0xFFFE; // (11111111-11111111-11111111-11111110)

            UInt32[] char_Mask = new UInt32[Char_Size]; // Mask for each ASCII character.

            // Reset all Character masks to '1's.
            for (int x = 0; x < Char_Size; x++)
            {
                char_Mask[x] = 0xFFFF;
            }
            
            // Set positions of all characters in search word as '0'
            for (int x = 0; x < searchWord.Length; x++)
            {
                char_Mask[searchWord[x]] &= ~(1U << x);
            }

            // Search loop.
            for (int x = 0; x < text.Length; x++)
            {
                // OR current State Mask with Character State Mask.
                state_Mask |= char_Mask[text[x]];

                // Shift Bits left. If a character match was found its '0' will be shifted to left.
                state_Mask <<= 1;

                // successive character matches correspond to movement of '0' to left due to left shift operation
                // until position of '0' reaches at the Index = Len(searchWord).
                if (0 == (state_Mask & (0x1U << searchWord.Length)))
                {
                    return x - searchWord.Length + 1;
                }
            }

            return -1;
        }

        // Maximum Word length 32 characters.
        public static int MatchFuzzy32Bit(string text, string searchWord, int distance)
        {
            // there are 256 ASCII characters
            const int Char_Size = 256;
            const int Max_Size = 32;

            if (searchWord.Length > Max_Size)
            {
                throw new Exception("Length not supported");
            }

            if (string.IsNullOrEmpty(searchWord))
            {
                return -1;
            }

            UInt32[] state_Mask = new UInt32[distance + 1];

            UInt32[] char_Mask = new UInt32[Char_Size]; // Mask for each ASCII character.

            for (int x = 0; x <= distance; x++)
            {
                state_Mask[x] = 0xFFFE; // (11111111-11111111-11111111-11111110)
            }

            for (int x = 0; x < Char_Size; x++)
            {
                char_Mask[x] = 0xFFFF;
            }

            // Set positions of all characters in search word as '0'
            for (int x = 0; x < searchWord.Length; x++)
            {
                char_Mask[searchWord[x]] &= ~(1U << x);
            }

            // Search loop.
            for (int x = 0; x < text.Length; x++)
            {
                // Save Exact Match State and '&' it with whatever fuzzy states become.
                // This will ensure that at the minimum exact match would be found.
                UInt32 State_Mask_0 = state_Mask[0];

                // OR current State Mask with Character State Mask.
                state_Mask[0] |= char_Mask[text[x]];

                // Shift Bits left. If a character match was found its '0' will be shifted to left.
                state_Mask[0] <<= 1;

                for (int d = 1; d <= distance; d++)
                {
                    // Save previous fuzzy state. to be used as minimum fuzzy match that next iteration will use.
                    UInt32 tmp = state_Mask[d];

                    // No matter what the result of fuzzy state '&' it with initial exact mask for this iteration and shift left.
                    // This will ensure fuzzy state always one bit ahead of previous index for this iteration.
                    state_Mask[d] = (State_Mask_0 & (state_Mask[d] | char_Mask[text[x]])) << 1;
                    
                    // previous state in iteration is starting point for next.
                    // this will increment lenvenshtine distance for next iteration if there is one.
                    State_Mask_0 = tmp;
                }

                // successive character matches correspond to movement of '0' to left due to left shift operation
                // until position of '0' reaches at the Index = Len(searchWord).
                if (0 == (state_Mask[distance] & (0x1U << searchWord.Length)))
                {
                    return x - searchWord.Length + 1;
                }

            }

            return -1;
        }

    }
}