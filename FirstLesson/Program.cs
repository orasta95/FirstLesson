
string[] people = { "Tom", "Alisa", "Bob", "Dilnoza", "Anna" };

foreach (var person in people)
{
    Console.WriteLine(person);
}

int[] numbers = { 12, 23, 213, 445, 23455 };
foreach (int number in numbers)
{
    Console.Write($"{number}, ");
}

int[] nums = { 1, 2, 3, 4, 5 };
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}