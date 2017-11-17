from django.db import models

# Create your models here.

class Equino(models.Model):
	#Campos
	nombre = models.CharField(max_length=50)
	raza = models.CharField(max_length=50)
	padre = models.CharField(max_length=50)
	madre = models.CharField(max_length=50)
	color = models.CharField(max_length=50)
	sexo = models.CharField(max_length=10)
	edad = models.IntegerField()
	peso = models.DecimalField(max_digits=5, decimal_places=2)
