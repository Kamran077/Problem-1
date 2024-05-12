#include <stdio.h>
#include <stdlib.h>


int main()
{
  int a,b,sum,sum1;
  scanf("%d",&a);
  scanf("%d",&b);

  if(a > b)
  {
    sum = a - b;
    printf("%d",sum);
    return 0;
  }
  sum1 = b - a;
  printf("%d",sum1);

  return 0;
}

