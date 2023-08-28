// #include <cs50.h>
#include <stdio.h>

int main(void)
{
 int start;
 int desired;
 int needed;
 int growth;
 int yearg;
 int newpop;
 int year;
 year = 0;
 printf("Starting Lamas: \n");
 scanf("%d", &start);
 printf("Desired lamas: \n");
 scanf("%d", &desired);
 growth = (start / 3) - (start / 4);
 while (start < desired) {
	 start = start + growth;
	 year ++;
 }
 printf("Starting lamas: %d\n", start);
 printf("Years:  %i\n", year);
    // TODO: Prompt for end size

    // TODO: Calculate number of years until we reach threshold

    // TODO: Print number of years
}
