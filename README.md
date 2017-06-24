# TimeChallenge

Given a digital time, your task is to return a string that represents this time in regular English. The time should be rounded to the nearest multiple of 5.

If you need help with time representation in English, check out this http://www.englisch-hilfen.de/en/words/uhr.htm for reference.

Example

For time_str = "12:00", the output should be
tellTime = "It's twelve o'clock".

For time_str = "08:42", the output should be
tellTime = "It's twenty to nine"

Input/Output

[time limit] 3000ms (cs)
[input] string time_str

The time in the hh:mm format. It is guaranteed that 1 ≤ hh ≤ 12, and 0 ≤ mm ≤ 59.

[output] string

time_str in common English.
