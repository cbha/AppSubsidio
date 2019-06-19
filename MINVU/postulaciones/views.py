from django.shortcuts import render
from django.http import HttpResponse
from django.contrib.auth.models import User
from django.contrib.auth import authenticate,logout,login
from django.shortcuts import redirect
from django.contrib.auth.decorators import login_required

def index(request):
    return render(request, 'index.html',{})

