#include <stdio.h>
#include <stdlib.h>

int main()
{
  long long a,b,sum1,sum2,total;
  scanf("%lld %lld",&a,&b);
  sum1 = a*a;
  sum2 = b*b;
  total = sum1 + sum2;

  printf("%lld",total);

  return 0;
}
