verzekering_per_maand = 23
benzine_kosten_per_liter = 1.54
liter_per_kilometer = 0.2
def bereken_maandkosten():
    maandkosten = (km_per_maand * liter_per_kilometer * benzine_kosten_per_liter) + verzekering_per_maand
    return maandkosten 
while True:
  try:
     print("Hoeveel km per maand?")
     km_per_maand = input()
     km_per_maand =float(km_per_maand)
  except ValueError:
     print("Geen nummer")
     continue
  else:
     print(bereken_maandkosten())
     input()
     break 