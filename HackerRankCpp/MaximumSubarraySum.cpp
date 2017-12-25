#include "stdafx.h"
#include "MaximumSubarraySum.h"
#include <iostream>
#include <set>
#include <algorithm>
using namespace std;

//https://www.hackerrank.com/challenges/maximum-subarray-sum/problem

MaximumSubarraySum::MaximumSubarraySum()
{
}

long long MaximumSubarraySum::Solve(long long n, long long m, long long * a)
{
	long long x, prefix = 0, maxim = 0;
	set<long long> S;
	S.insert(0);
	for (int i = 1; i <= n; i++) {
		x = a[i];
		prefix = (prefix + x) % m;
		maxim = max(maxim, prefix);
		set<long long>::iterator  it = S.lower_bound(prefix + 1);
		if (it != S.end()) {
			maxim = max(maxim, prefix - (*it) + m);
		}
		S.insert(prefix);
	}
	return maxim;
}



MaximumSubarraySum::~MaximumSubarraySum()
{
}
