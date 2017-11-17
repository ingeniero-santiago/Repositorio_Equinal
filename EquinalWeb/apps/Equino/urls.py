from django.conf.urls import url,include

#Importamos las vistas
from apps.Equino.views import index,equino_list,equino_calificacion
urlpatterns = [
    url(r'^$', index, name="index"),
    url(r'^lista$', equino_list, name='equino_lista'),
    url(r'^calificacion$', equino_calificacion, name='equino_calificacion'),
]
