#pragma once
#include <string>

#ifdef DLL_EXPORTS
#define QUADEQ_API __declspec(dllexport)
#else
#define QUADEQ_API __declspec(dllimport)
#endif

extern "C" QUADEQ_API double countRoot(int a, int b, int c, int mod);
extern "C" QUADEQ_API double countPeak(int a, int b, int c, char axis);
extern "C" QUADEQ_API double countDisc(int a, int b, int c);
