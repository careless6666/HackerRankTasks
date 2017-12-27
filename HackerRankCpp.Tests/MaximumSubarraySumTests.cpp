#include "stdafx.h"
#include "CppUnitTest.h"
#include "MaximumSubarraySum.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace HackerRankCppTests
{
	TEST_CLASS(MaximumSubarraySumTests)
	{
	public:

		TEST_METHOD(TestMaximumSubarraySum)
		{
			auto * mss = new MaximumSubarraySum;
			long long a[5] = { 3, 3, 9, 9, 5 };
			long long res = mss->Solve(5, 7, a);
			long long expectec = 6;
			Assert::IsTrue(expectec == res);
		}
	};
}