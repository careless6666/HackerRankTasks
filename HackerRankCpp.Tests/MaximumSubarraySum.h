#pragma once

#define MaximumSubarraySum_Api

class __declspec(dllexport) MaximumSubarraySum
{
public:
	MaximumSubarraySum();
	long long Solve(long long n, long long m, long long * a);
	~MaximumSubarraySum();
};

