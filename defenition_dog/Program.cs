int first_man_speed = 1;
int second_man_speed = 2;
int dog_speed = 5;
int distance = new Random().Next(500, 100000);
int count = 0;
int friend = 2;
int time = 0;
Console.WriteLine(distance);
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(second_man_speed + dog_speed);
        friend = 1;
    }
    else
    {
        time = distance/(first_man_speed + dog_speed);
        friend = 2;
    }
    distance = distance - (first_man_speed + second_man_speed)*time;
    count++;
}
Console.WriteLine(count);