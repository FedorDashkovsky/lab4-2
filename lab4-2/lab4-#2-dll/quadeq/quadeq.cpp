#include "pch.h"
#include <utility>
#include <limits.h>
#include <string>
#include "quadeq.h"

double countDisc(int a, int b, int c) {
	double D = pow(b, 2) - (4 * a * c);
	return D;
}

double countRoot(int a, int b, int c, int mod) {
	double D = countDisc(a, b, c);
	double x;
	switch (mod) {
	case 1: {
		x = (-b - pow(D, 0.5)) / (2 * a);
		return x;
	}
	case 2: {
		x = (-b + pow(D, 0.5)) / (2 * a);
		return x;
	}
	}
}

double countPeak(int a, int b, int c, char axis) {
	double D = countDisc(a, b, c);
	switch (axis) {
	case 'X': {
		double x0 = (-b * 1.0) / (2 * a);
		return x0;
	}
	case 'Y': {
		double y0 = -D / (4 * a);
		return y0;
	}
	}
}