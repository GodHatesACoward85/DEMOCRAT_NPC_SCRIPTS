#include "pch.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define ARRAYSIZE(a) sizeof(a) / sizeof(a[0])

#define DONALD_JOHN_TRUMP 1
#define HILLARY_RODHAM_CLINTON 0

const char* TALKING_POINTS[] = {
	"Xenophobic",
	"Racist",
	"Nazi",
	"You're a fucking white male",
	"Disenfranchized",
	"Mansplaining",
	"Gender is a social construct, even tho I had at one point a cock and balls and cannot birth children call me a woman you bigot!",
	"Socio-economic norms",
	"HOW ABSOLUTELY DARE YOU!",
	"we are healthy at every size",
	"this is america",
	"REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
	"ASSAULT RIFLE",
	"Bi-Partisan",
	"Racism",
	"That wasn't real socialism, lol",
	"Justice",
	"RUSSIA",
	"My welfare check came late, sorry",
	"WE got a choppa inna trunk for donald trum",
	"Bigot",
	"This is how democracy dies... with thunderous applause",
	"Womens rights! I have the right to murder, you just don't understand women!",
	"PEACHMINTS FOWTY FIIII",
	"Reported!"
};

bool NotMyPresident() {
	int kek = 1;

	return (kek == DONALD_JOHN_TRUMP);
}

bool isItHerTurn() {
	return !NotMyPresident();
}

const char* RandomLeftistGibberish() {

	srand(time(NULL));

	int index = rand() % ARRAYSIZE(TALKING_POINTS);

	return TALKING_POINTS[index];
}

int main()
{
	while (!isItHerTurn()) {
		printf(RandomLeftistGibberish());
	}
}

