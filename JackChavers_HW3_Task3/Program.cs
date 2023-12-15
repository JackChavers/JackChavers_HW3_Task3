// Jack Chavers
// HW3 Task3 TutitionIncrease

double tuitionAmount = 12000.0;

int N = 7;

for(int i = 0; i < N; i++)
{
    tuitionAmount = tuitionAmount * (1 + 0.05);
    string message = string.Format($"The tuition after year {i + 1} will be {tuitionAmount:C0}.");
    Console.WriteLine(message);

}