Console.Clear();

double path = 100;
int minDist = 3;
int speedFriend1 = 1;
int speedFriend2 = 2;
int speedDog = 5;
int choiceFriend = 1; // у какого друга в настоящий момент собака
int count = 0;
double timePath = 0;

while (path > minDist)
{
    if (choiceFriend == 1)
    {
        timePath = path / (speedDog + speedFriend2);
        path = path - timePath * (speedFriend1 + speedFriend2);
        choiceFriend = 2;
    }
    else
    {
        timePath = path / (speedDog + speedFriend1);
        path = path - timePath * (speedFriend1 + speedFriend2);
        choiceFriend = 1;
    }
    count++;
   // Console.WriteLine($"кол-во = {count}, расстояние между друзьями = {path}.");
}
Console.WriteLine($"За время пока 2 друга идут на встречу друг другу, собака пробежит между ними {count} раз.");
