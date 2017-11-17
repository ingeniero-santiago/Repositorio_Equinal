from django.shortcuts import render
from django.http import HttpResponse

#Importamos los modelos
from apps.Equino.models import Equino
# Create your views here.

def index(request):
	#return HttpResponse("Hola Sofía Cano!")
	return render(request, 'equino/index.html')

def equino_list(request):
	#QuerySets
	equino = Equino.objects.all()
	contexto = {'equinos':equino}
	return render(request, 'equino/equino_list.html', contexto)
def equino_calificacion(request):
	#QuerySets
	#equino = Equino.objects.all()
	#contexto = {'equinos':equino}
	return render(request, 'equino/equino_calificacion.html')
