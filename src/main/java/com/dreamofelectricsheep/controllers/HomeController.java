package com.dreamofelectricsheep.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.ui.Model;

@Controller
public class HomeController {

    @RequestMapping("")
    public String index(Model model) {
        String home = "uses request mapping";
        model.addAttribute("home", home);
        return "index";
    }

    @RequestMapping("/hello")
    public String hello() {
        return "hello";
    }
}
